using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabaseEntity.Model
{
  public  class Customer
  {
    [Key]
    public int CustomerID { get; set; }             //Unique Identifier property for the class 
    public string? Firstname { get; set; }          //Nullable property for the customer's Firstname
    public string? Lastname { get; set; }           //Nullable property for the customer's Lastname
        public string? email { get; set; }          //Nullable property for the customer's email
        public string? Address { get; set; }        //Nullable property for the customer's Address
        public int? phoneNum { get; set; }          //Nullable property for the customer's phone number

    public string FullName                          //method that Returns the full name by conecting the Firstname and Lastname properties with a space in between.
    {
      get
      {
        return Firstname+ " " + Lastname;
      }
    }
  }
}
