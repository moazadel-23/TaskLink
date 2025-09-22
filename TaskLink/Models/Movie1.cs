using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Table("movie", Schema = "new")]
public partial class Movie1
{
    [Key]
    [Column("mov_id")]
    public int MovId { get; set; }

    [Column("mov_title")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MovTitle { get; set; }

    [Column("mov_year")]
    public int? MovYear { get; set; }

    [Column("mov_time")]
    public int? MovTime { get; set; }

    [Column("mov_lang")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MovLang { get; set; }

    [Column("mov_dt_rel")]
    public DateOnly? MovDtRel { get; set; }

    [Column("mov_rel_country")]
    [StringLength(5)]
    [Unicode(false)]
    public string? MovRelCountry { get; set; }
}
