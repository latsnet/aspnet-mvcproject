using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_project.Models;

[Table("UserGroup")]
public class UserGroup
{
    [Key]
    public int UserGroupId { get; set; }
    public string UserGroupDescription { get; set; }
    public List<User> Users { get; set; }

}