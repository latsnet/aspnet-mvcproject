using System;
using System.Collections.Generic;

namespace mvc_project.Data.Models;

public class User
{
    public int ID { get; set; }

    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

}