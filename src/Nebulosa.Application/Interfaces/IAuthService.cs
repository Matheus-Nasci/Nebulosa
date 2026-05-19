namespace Nebulosa.Application.Interfaces;

public interface IAuthService
{
    object AuthJwtUser(object user);
}