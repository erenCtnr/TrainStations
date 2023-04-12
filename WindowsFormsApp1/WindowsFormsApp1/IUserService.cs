

public interface IUserService
{
    ServiceResult<UserDto> RegisterUser(RegisterViewModel model);
    ServiceResult<UserDto> Login(LoginViewModel model);
}
