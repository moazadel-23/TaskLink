using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Keyless]
public partial class ProductionView
{
    [Column("product_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string ProductName { get; set; } = null!;

    [Column("brand_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string BrandName { get; set; } = null!;

    [Column("list_price", TypeName = "decimal(10, 2)")]
    public decimal ListPrice { get; set; }
}
