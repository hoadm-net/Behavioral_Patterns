namespace Strategy.classes;

public interface IAuthenticationStrategy
{
    bool Authenticate(string credentials);
}