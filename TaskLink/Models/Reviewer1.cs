using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Table("reviewer", Schema = "new")]
public partial class Reviewer1
{
    [Key]
    [Column("rev_id")]
    public int RevId { get; set; }

    [Column("rev_name")]
    [StringLength(30)]
    [Unicode(false)]
    public string? RevName { get; set; }
}
