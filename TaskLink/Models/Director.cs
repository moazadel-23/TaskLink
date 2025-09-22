using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Table("director", Schema = "new")]
public partial class Director
{
    [Key]
    [Column("dir_id")]
    public int DirId { get; set; }

    [Column("dir_fname")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DirFname { get; set; }

    [Column("dir_lname")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DirLname { get; set; }
}
