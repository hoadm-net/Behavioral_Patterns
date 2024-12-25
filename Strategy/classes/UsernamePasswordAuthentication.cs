namespace Strategy.classes;

public class UsernamePasswordAuthentication : IAuthenticationStrategy
{
    public bool Authenticate(string credentials)
    {
        // Giả sử credentials là "username:password"
        var parts = credentials.Split(':');
        if (parts.Length == 2 && parts[0] == "admin" && parts[1] == "1234")
        {
            Console.WriteLine("Authenticated using Username and Password.");
            return true;
        }
        return false;
    }
}