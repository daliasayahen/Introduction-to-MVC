using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_From_Scratch.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
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