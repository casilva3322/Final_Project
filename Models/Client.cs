using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Final_Project.Models
{
    public class Client : Particpant
    {
         [Display(Name="Company Name")]
         public string CoName {get;set;}
    }
}