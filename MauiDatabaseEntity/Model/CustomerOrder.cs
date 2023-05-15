using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabaseEntity.Model
{
  public class CustomerOrder
  {
    [Key]
    public int OrderID { get; set; }                //Unique identifier property for the Customer Order class 

    [ForeignKey("Customer")]
    public int CustomerID { get; set; }             //Specifies 'CustomerID' property is a foreign key column in the db table, that references the Customer table.
    public string? Item { get; set; }               //Nullable property for storing the Item

    public string? ItemPic { get; set; }            //Nullable property for storing the Item pic
    public double Total { get; set; }               //Nullable property for storing the Total cost of order 

    public DateTime ReturnDate { get; set; }        //Nullable property for storing the date for item to be returned 


    // Represents a nullable string property named ReturnDatetext.
    // The property's value is derived by connecting the string "To be returned by:\n " with the formatted representation of the ReturnDate property,
    // using the "dd/MM/yy" date format.
    public String? ReturnDatetext { get { return "To be returned by:\n " + ReturnDate.ToString("dd/MM/yy"); } } 

  }
}
