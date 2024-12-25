namespace Strategy.classes;

public class AuthenticationSystem
{
    private IAuthenticationStrategy _strategy;
    
    public void SetAuthenticationStrategy(IAuthenticationStrategy strategy)
    {
        _strategy = strategy;
    }

    public bool AuthenticateUser(string credentials)
    {
        if (_strategy == null)
        {
            throw new InvalidOperationException("Authentication strategy is not set.");
        }
        return _strategy.Authenticate(credentials);
    }
}