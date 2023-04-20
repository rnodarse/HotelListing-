using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;
        
        //Notice in constructor below how is taking a copy of the context and passing it to the base. I am not clear about that
        public CountriesRepository(HotelListingDbContext context, IMapper mapper) : base(context,mapper)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Coutries.Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }

        
    }
}
