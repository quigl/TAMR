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
    public int OrderID { get; set; }

    [ForeignKey("Customer")]
    public int CustomerID { get; set; }
    public string? Item { get; set; }

    public string? ItemPic { get; set; }
    public double Total { get; set; }

    public DateTime ReturnDate { get; set; }

    public String? ReturnDatetext { get { return "To be returned by:\n " + ReturnDate.ToString("dd/MM/yy"); } }

  }
}
