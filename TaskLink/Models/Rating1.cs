using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Keyless]
[Table("rating", Schema = "new")]
public partial class Rating1
{
    [Column("mov_id")]
    public int? MovId { get; set; }

    [Column("rev_id")]
    public int? RevId { get; set; }

    [Column("rev_stars")]
    public int? RevStars { get; set; }

    [Column("num_o_rating")]
    public int? NumORating { get; set; }

    [ForeignKey("MovId")]
    public virtual Movie1? Mov { get; set; }

    [ForeignKey("RevId")]
    public virtual Reviewer1? Rev { get; set; }
}
