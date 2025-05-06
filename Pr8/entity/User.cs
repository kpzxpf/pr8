namespace Pr8.entity;

public class User
{
    public int id { get; private set; }
    public string last_name { get; set; }
    public string first_name { get; set; }
    public string middle_name { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public UserRole role { get; set; }
    
    public enum UserRole
    {
        User,
        Admin
    }
}