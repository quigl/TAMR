using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabaseEntity.Model
{
  public class Admin
  {
    [Key]
    public int ID { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }
    public string? Username { get; set; }

    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? PhoneNum { get; set; }
  }
}
