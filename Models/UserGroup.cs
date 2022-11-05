namespace mvc_project.Models;

public class UserGroup
{
    public int UserGroupId { get; set; }
    public string UserGroupDescription { get; set; }
    public List<User> Users { get; set; }

}