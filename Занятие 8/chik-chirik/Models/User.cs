namespace chik_chirik.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } // JSONPlaceholder uses 'username' instead of 'name'
        public string Name { get; set; }
        public string Email { get; set; }
    }
}