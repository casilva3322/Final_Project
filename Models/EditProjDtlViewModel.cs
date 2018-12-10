using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Final_Project.Models
{
    public class EditProjectDetailViewModel
    {

        public int EditProjViewModel {get;set;}


        public string SelectedID { get; set; }
        public Project startProject {get;set;}

        public List<SelectListItem> ClientsList { get; set; }
        
        public List<SelectListItem> MembersList { get; set; }

        
    }
}