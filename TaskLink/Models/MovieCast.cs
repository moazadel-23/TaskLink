using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Table("movie_cast")]
public partial class MovieCast
{
    [Key]
    [Column("mov_id")]
    public int MovId { get; set; }

    [Column("act_id")]
    public int? ActId { get; set; }

    [Column("role")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Role { get; set; }

    [ForeignKey("ActId")]
    [InverseProperty("MovieCasts")]
    public virtual Actor? Act { get; set; }
}
