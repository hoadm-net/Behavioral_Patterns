namespace Strategy.classes;

public class FingerprintAuthentication : IAuthenticationStrategy
{
    public bool Authenticate(string credentials)
    {
        // Giả sử credentials là fingerprint data
        if (credentials == "valid-fingerprint")
        {
            Console.WriteLine("Authenticated using Fingerprint.");
            return true;
        }

        return false;
    }
}