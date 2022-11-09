using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mvc_project.Models;

[Table("User")]
public class User
{
    [Key]
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int UserGroupId { get; set; }
    public virtual UserGroup UserGroup { get; set; }

}