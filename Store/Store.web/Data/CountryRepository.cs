
namespace Store.web.Data
{
    using Store.web.Data.Entities;


    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context) : base(context)
        {

        }
    }
}
