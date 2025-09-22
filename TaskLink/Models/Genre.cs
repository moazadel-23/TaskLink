using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Table("genres", Schema = "new")]
public partial class Genre
{
    [Key]
    [Column("gen_id")]
    public int GenId { get; set; }

    [Column("gen_title")]
    [StringLength(20)]
    [Unicode(false)]
    public string? GenTitle { get; set; }
}
