namespace Strategy.classes;

public class OAuthAuthentication : IAuthenticationStrategy
{
    public bool Authenticate(string credentials)
    {
        // Giả sử credentials là token
        if (credentials == "valid-oauth-token")
        {
            Console.WriteLine("Authenticated using OAuth.");
            return true;
        }
        return false;
    }
}