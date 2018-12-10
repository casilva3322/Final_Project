using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Final_Project.Models
{//2
    public class Project
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Project Name")]                
        public string ProjName { get; set; }
        [Display(Name = "Project Description")]                
        public string ProjDescript { get; set; }
        public ICollection<ProjInfo> Partcipants { get; set; }

        public override string ToString(){
        return $"Project Name: {this.ProjName}\nProject Description: {this.ProjDescript}";
        
    }
}
}
