using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Table("product_audits", Schema = "production")]
public partial class ProductAudit
{
    [Key]
    [Column("change_id")]
    public int ChangeId { get; set; }

    [Column("product_id")]
    public int ProductId { get; set; }

    [Column("product_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string ProductName { get; set; } = null!;

    [Column("brand_id")]
    public int BrandId { get; set; }

    [Column("category_id")]
    public int CategoryId { get; set; }

    [Column("model_year")]
    public short ModelYear { get; set; }

    [Column("list_price", TypeName = "decimal(10, 2)")]
    public decimal ListPrice { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime UpdatedAt { get; set; }

    [Column("operation")]
    [StringLength(3)]
    [Unicode(false)]
    public string Operation { get; set; } = null!;
}
