using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskLink.Models;

[Table("employees", Schema = "Sale")]
public partial class Employee1
{
    [Key]
    [Column("employee_id")]
    public int EmployeeId { get; set; }

    [Column("first_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [Column("salary", TypeName = "decimal(8, 2)")]
    public decimal? Salary { get; set; }

    [Column("hire_date")]
    public DateOnly? HireDate { get; set; }
}
