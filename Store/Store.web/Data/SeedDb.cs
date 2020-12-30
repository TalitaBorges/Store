using Store.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.web.Data
{
    public class SeedDb
    {
        private readonly DataContext context;

        private Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if(!this.context.Products.Any())
            {
                this.AddProduct("Equipamento Oficial");
                this.AddProduct("Vestuario Oficial");
                this.AddProduct("Bonecos Oficial");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddProduct(string v)
        {
            throw new NotImplementedException();
        }

        private void AddProducts(string name)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(200),
                IsAvailable = true,
                Stock = this.random.Next(100)
            });
        }
    }
}
