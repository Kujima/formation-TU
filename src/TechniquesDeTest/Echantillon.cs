namespace TechniquesDeTest;

public class Echantillon
{
    public string FullName = "Sylvanas Coursevent";
    public int Age = 30;

    internal DateOnly DateOfBirth = new(1993, 1, 1);

    public User AppUser = new User()
    {
        FullName = "Sylvanas Coursevent",
        Age = 30,
        DateOfBirth = new(1993, 1, 1)
    };

    public IEnumerable<User> Users = new[]
    {
        new User()
        {
            FullName = "Sylvanas Coursevent",
            Age = 30,
            DateOfBirth = new(1993, 1, 1)
        },
        new User()
        {
            FullName = "Jaina Portvaillant",
            Age = 25,
            DateOfBirth = new(1998, 1, 1)
        },
        new User()
        {
            FullName = "Arthas Menethil",
            Age = 23,
            DateOfBirth = new(2000, 1, 1)
        },
    };

    public void Register(int age)
    {
        if (age < 18)
            throw new AgeMustBeGreaterThan18();
    }

    public class AgeMustBeGreaterThan18 : Exception
    {
        public AgeMustBeGreaterThan18() : base("L'age doit être supérieur à 18 ans.")
        {
            
        }
    }

    public IEnumerable<int> Numbers = new[] { 1, 5, 7, 10, 15, 20 };
    public event EventHandler ExampleEvent;

    public void RaiseExampleEvent()
    {
        ExampleEvent(this, EventArgs.Empty);
    }
    
    public class User
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}