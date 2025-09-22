using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Keyless]
[Table("emp2", Schema = "sales")]
public partial class Emp2
{
    [Column("first_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [Column("last_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;
}
