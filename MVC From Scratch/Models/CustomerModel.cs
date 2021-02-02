using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_From_Scratch.Models
{
    //data annotation :attribute added to property to check the validation of data that send to this property
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="please enter your name")]
        public string Name { get; set; }
        [Required (ErrorMessage ="please Enter your Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "please enter your Age")]
        public int Age { get; set; }

        public CustomerModel()
        {


        }
        public CustomerModel(int id, string name , string adress , int age)
        {
            Id = id;
            Name = name;
            Address = adress;
            Age = age;


        }
    }
}