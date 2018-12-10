using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Final_Project.Models
{
    public class ProjInfo
    {
        public string ParticipantID { get; set; }
        public Particpant Participant { get; set; }
        public int ProjID { get; set; }
        public Project Project { get; set; } 
    }
}