using Carsweb.Data;
using Carsweb.Models;

namespace Carsweb.Services.Implementation
{
    public class CarService
    {
        private readonly AppDbContext _context;

        public CarService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cars>> GetAllAsync()
        {
            return _context.Cars.ToList();
        }
    }
}
