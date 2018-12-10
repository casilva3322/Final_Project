using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public  class Particpant
    {   
        [Key]
        public string ID { get; set; }
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumb { get; set; }
       public ICollection<ProjInfo> Projects { get; set; }

        public override string ToString(){
        return $"First Name: {this.FName} Last Name: {this.LName}";
    }
}
}