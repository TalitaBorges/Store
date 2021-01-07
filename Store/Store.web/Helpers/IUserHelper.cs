namespace Store.web.Helpers
{
    using Microsoft.AspNetCore.Identity;
    using Store.web.Data.Entities;
    using Store.web.Models;
    using System.Threading.Tasks;


    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();
        
    }
}
