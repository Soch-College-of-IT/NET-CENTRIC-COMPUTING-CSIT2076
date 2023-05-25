using WebAPIDemo.Models;

namespace WebAPIDemo.Services;
public static class UserService
{
    static List<User> Users { get; }
    static int nextId = 3;
    static UserService()
    {
        Users = new List<User>
        {
            new User { Id = 1, Name = "John Doe", EmailAddress = "johndoe@example.com", PhoneNumber = "555-555-5555" },
            new User { Id = 2, Name = "Jane Doe", EmailAddress = "jane@example.com", PhoneNumber = "444-444-4444"   }
        };
    }

    public static List<User> GetAll() => Users;

    public static User? Get(int id) => Users.FirstOrDefault(p => p.Id == id);

    public static void Add(User user)
    {
        user.Id = nextId++;
        Users.Add(user);
    }

    public static void Delete(int id)
    {
        var user = Get(id);
        if (user is null)
            return;

        Users.Remove(user);
    }

    public static void Update(User user)
    {
        var index = Users.FindIndex(p => p.Id == user.Id);
        if (index == -1)
            return;

        Users[index] = user;
    }
}