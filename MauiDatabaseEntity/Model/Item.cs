using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabaseEntity.Model
{
  public class Item
  {
    public string? Name { get; set; }
    public double price { get; set; }
    public string? ItemPic { get; set; }
  }
}
