using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabaseEntity.Model
{
    //Admin class 
  public class Admin
  {
    [Key]
    public int ID { get; set; }                 //Unique identifier property for the class 

    public string? Firstname { get; set; }      //Nullable property for storing the firstname 

    public string? Lastname { get; set; }       //Nullable property for storing the lastname
    public string? Username { get; set; }       //Nullable property for storing the firstname

    public string? Password { get; set; }       //Nullable property for storing the Password
    public string? Email { get; set; }          //Nullable property for storing the Email
    public string? Address { get; set; }        //Nullable property for storing the Address
    public string? PhoneNum { get; set; }       ///Nullable property for storing the phone number
  }
}
