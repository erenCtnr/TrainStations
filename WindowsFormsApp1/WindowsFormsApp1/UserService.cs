using TrenIstasyonuProjesi.Models;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly ITokenService _tokenService;

    public UserService(IUserRepository userRepository, ITokenService tokenService)
    {
        _userRepository = userRepository;
        _tokenService = tokenService;
    }

    public ServiceResult<UserDto> RegisterUser(RegisterViewModel model)
    {
        var existingUser = _userRepository.GetByUsername(model.Username);

        if (existingUser != null)
        {
            return ServiceResult<UserDto>.Error("A user with the same username already exists.");
        }

        var newUser = new User
        {
            Username = model.Username,
            Password = BCrypt.Net.BCrypt.HashPassword(model.Password)
        };

        _userRepository.Add(newUser);

        var userDto = new UserDto
        {
            Id = newUser.Id,
            Username = newUser.Username
        };

        return ServiceResult<UserDto>.Success(userDto, "User registered successfully.");
    }

    public ServiceResult<UserDto> Login(LoginViewModel model)
    {
        var user = _userRepository
    } 
}
