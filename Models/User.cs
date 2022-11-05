using System;
using System.Collections.Generic;

namespace mvc_project.Models;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int UserGroupId { get; set; }
    public virtual UserGroup UserGroup { get; set; }

}