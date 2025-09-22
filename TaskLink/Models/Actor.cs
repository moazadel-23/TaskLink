using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Table("actor")]
public partial class Actor
{
    [Key]
    [Column("act_id")]
    public int ActId { get; set; }

    [Column("act_fname")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ActFname { get; set; }

    [Column("act_lname")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ActLname { get; set; }

    [Column("act_gender")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ActGender { get; set; }

    [InverseProperty("Act")]
    public virtual ICollection<MovieCast> MovieCasts { get; set; } = new List<MovieCast>();
}
