using Strategy.classes;

namespace Strategy;

class Program
{
    static void Main(string[] args)
    {
        AuthenticationSystem authSystem = new AuthenticationSystem();

        // Authenticate using Username and Password
        authSystem.SetAuthenticationStrategy(new UsernamePasswordAuthentication());
        Console.WriteLine("Result: " + authSystem.AuthenticateUser("admin:1234")); // True
        Console.WriteLine();

        // Authenticate using OAuth
        authSystem.SetAuthenticationStrategy(new OAuthAuthentication());
        Console.WriteLine("Result: " + authSystem.AuthenticateUser("valid-oauth-token")); // True
        Console.WriteLine();

        // Authenticate using Fingerprint
        authSystem.SetAuthenticationStrategy(new FingerprintAuthentication());
        Console.WriteLine("Result: " + authSystem.AuthenticateUser("valid-fingerprint")); // True
        Console.WriteLine();

        // Attempt invalid authentication
        Console.WriteLine("Attempt invalid authentication...");
        authSystem.SetAuthenticationStrategy(new UsernamePasswordAuthentication());
        Console.WriteLine("Result: " + authSystem.AuthenticateUser("invalid:credentials")); // False
    }
}