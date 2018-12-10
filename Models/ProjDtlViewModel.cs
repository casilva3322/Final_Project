using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class ProjDtlViewModel
    {
        public int ProjID { get; set; }
        public Project Project { get; set; }
        public int SelectedID { get; set; }
        public List<Client> Clients { get; set; }
        public List<Member> Members { get; set; }
    }
}