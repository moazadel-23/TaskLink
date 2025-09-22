using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Table("reviewer")]
public partial class Reviewer
{
    [Key]
    [Column("rec_id")]
    public int RecId { get; set; }

    [Column("rev_name")]
    [StringLength(30)]
    [Unicode(false)]
    public string? RevName { get; set; }
}
