using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Keyless]
[Table("movie_genres", Schema = "new")]
public partial class MovieGenre
{
    [Column("mov_id")]
    public int? MovId { get; set; }

    [Column("gen_id")]
    public int? GenId { get; set; }

    [ForeignKey("GenId")]
    public virtual Genre? Gen { get; set; }

    [ForeignKey("MovId")]
    public virtual Movie1? Mov { get; set; }
}
