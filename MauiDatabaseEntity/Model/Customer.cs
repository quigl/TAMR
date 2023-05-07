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
    public int CustomerID { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public string? email { get; set; }
    public string? Address { get; set; }
    public string? phoneNum { get; set; }

    public string FullName
    {
      get
      {
        return Firstname+ " " + Lastname;
      }
    }
  }
}
