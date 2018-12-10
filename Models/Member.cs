using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace Final_Project.Models
{
    public class Member:Particpant
    {   
       

        [Display(Name = "Major")]                
        public string Mjr {get; set;}


        
    }
}