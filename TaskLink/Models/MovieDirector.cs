using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Keyless]
[Table("movie_director", Schema = "new")]
public partial class MovieDirector
{
    [Column("dir_id")]
    public int? DirId { get; set; }

    [Column("mov_id")]
    public int? MovId { get; set; }

    [ForeignKey("DirId")]
    public virtual Director? Dir { get; set; }

    [ForeignKey("MovId")]
    public virtual Movie1? Mov { get; set; }
}
