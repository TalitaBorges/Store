namespace Store.web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Store.web.Data.Entities;
    using Store.web.Helpers;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly Random random;

        public SeedDb(DataContext context,IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("about.talitaborges@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Talita",
                    LastName = "Borges",
                    Email = "about.talitaborges@gmail.com",
                    UserName = "about.talitaborges@gmail.com",
                    PhoneNumber = "213456789"
                };

                var result = await this.userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }


            if (!this.context.Products.Any())
            {
                this.AddProduct("Equipamento Oficial", user);
                this.AddProduct("Vestuario Oficial", user);
                this.AddProduct("Bonecos Oficial", user);
                await this.context.SaveChangesAsync();
            }
        }


        private void AddProduct(string name, User user)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(200),
                IsAvailable = true,
                Stock = this.random.Next(100),
                User = user
            });
        }
    }
}
