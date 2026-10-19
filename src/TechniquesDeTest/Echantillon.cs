namespace TechniquesDeTest;

public class Echantillon
{
    public string FullName { get; set; }
    public int Age = 30;

    public DateOnly DateOfBirth = new(1993, 1, 1);

    public User AppUser = new User()
    {
        FullName = "Sylvanas Coursevent",
        Age = 30,
        DateOfBirth = new(1993, 1, 1)
    };
    
    public IEnumerable<User> Users = new[] 

    public IEnumerable<int> Numbers = new[] { 1, 5, 7, 10, 15, 20 };
    public event EventHandler ExempleEvent;
    
    public class User
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}