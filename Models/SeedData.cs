
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Final_Project.Models
{
    
    public class SeedData
    {
            public static void Seed(IApplicationBuilder app)
            {
                var context = app.ApplicationServices.GetRequiredService<BffTekWebContext>();
                context.Database.EnsureCreated();
                
                
               
                if(!context.Clients.Any())
                {
                    
                 var clients = new List<Client>
                {

                        new Client {FName="Creed", LName="Bratton",CoName="ScubaGear", Email="scubashop123@gmail.com",PhoneNumb="888-888-8888"},
                        new Client {FName="Jan", LName="Levinson",CoName="DiamondExpress", Email="doughnutshopabc@gmail.com", PhoneNumb="777-777-7777"},
                        new Client {FName="Dwight", LName="Schrute", CoName="Cakes and More", Email="cakesandmore555@gail.com", PhoneNumb="666-666-6666"},
                        new Client {FName="Oscar", LName="Martinez", CoName="Plants and More", Email="plantsandmore@gmail.com", PhoneNumb="555-555-5555"},

                  
                };
                context.AddRange(clients);
                context.SaveChanges();
               
               if(!context.Members.Any())
               {
                   
                var members = new List<Member>
                {
                    new Member{ FName="Micheal", LName="Scott", Mjr="CIS", Email="abc123@buffs.wtamu.edu", PhoneNumb="444-444-4444"},
                    new Member{FName="Tobby", LName="Flenderson", Mjr="CIS", Email="xzy987@buffs.wtamu.edu", PhoneNumb="222-222-2222"},
                    new Member{FName="Jim", LName="Halpert", Mjr="CIS", Email="dfgh678@buffs.wtamu.edu", PhoneNumb="111-111-1111"},
                    new Member{FName="Pam", LName="Beesly", Mjr="CIS", Email="hygt677@buffs.wtamu.edu", PhoneNumb="222-555-2222"},
                    new Member{FName="Ryan", LName="Howard", Mjr="CIS", Email="dxdc555@buffs.wtamu.edu", PhoneNumb="111-111-6666"},
                    new Member{ FName="Andy", LName="Bernard", Mjr="CIS", Email="jhjh777@buffs.wtamu.edu", PhoneNumb="333-444-4444"},
                    new Member{FName="Robert", LName="California", Mjr="CIS", Email="tyty333@buffs.wtamu.edu", PhoneNumb="444-222-2222"},
                    new Member{FName="Kelly", LName="Kapoor", Mjr="CIS", Email="fcfc555@buffs.wtamu.edu", PhoneNumb="999-111-1111"},
                    new Member{FName="Meredith", LName="Palmer", Mjr="CIS", Email="okok111@buffs.wtamu.edu", PhoneNumb="888-555-2222"},
                    new Member{FName="Stanley", LName="Hudson", Mjr="CIS", Email="hyhy333@buffs.wtamu.edu", PhoneNumb="777-111-6666"},
                    
                };
                context.AddRange(members);
                context.SaveChanges();
                

                if (!context.Projects.Any())
                {
                   
                var projects = new List<Project>
                {
                  
                   
                    new Project {ProjName="Diagrams", ProjDescript="Create Diagrams"},
                    new Project {ProjName="FrontEnd", ProjDescript="Add HTML and CSS"},
                    new Project {ProjName="BackEnd", ProjDescript="Add Javascript"},
                };
                context.AddRange(projects);
                context.SaveChanges();
                if(!context.ProjInfo.Any())
                {
                    

               var projectsFromDb = context.Projects.ToList();
               var clientsFromDb = context.Clients.ToList();
                var membersFromDb = context.Members.ToList();

                var projectinfo = new List<ProjInfo>
                {
                    //take the first project from above, the first client from above, and the first three students from above.
                    new ProjInfo { ProjID = projectsFromDb.ElementAt(0).ID,
                                        Project = projectsFromDb.ElementAt(0), 
                                        ParticipantID = clientsFromDb.ElementAt(0).ID.ToString(),
                                        Participant = clientsFromDb.ElementAt(0) },

                    new ProjInfo { ProjID = projectsFromDb.ElementAt(0).ID, 
                                        Project = projectsFromDb.ElementAt(0), 
                                        ParticipantID = membersFromDb.ElementAt(0).ID.ToString(),
                                        Participant = membersFromDb.ElementAt(0) },

                    new ProjInfo { ProjID = projectsFromDb.ElementAt(0).ID, 
                                        Project = projectsFromDb.ElementAt(0), 
                                        ParticipantID = membersFromDb.ElementAt(1).ID,
                                        Participant = membersFromDb.ElementAt(1) },

                    new ProjInfo { ProjID = projectsFromDb.ElementAt(0).ID, 
                                        Project = projectsFromDb.ElementAt(0), 
                                        ParticipantID = membersFromDb.ElementAt(2).ID.ToString(),
                                        Participant = membersFromDb.ElementAt(2) },                                        
                };
                context.AddRange(projectinfo);
                context.SaveChanges();                

            }
            else
                return;
        }
    }
}
            }
    }
}
           

                