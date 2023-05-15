using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabaseEntity.Model
{
    //Item class
  public class Item
  {
    public string? Name { get; set; }       //Nullable property for Name
    public double price { get; set; }       //Property for price
    public string? ItemPic { get; set; }    //Nullable Property for Item Pic
  }
}
