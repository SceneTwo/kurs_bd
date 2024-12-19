using DataBaseStorage;
using DataBaseStorage.entities;

namespace DataBaseLogic.Repositories
{
    public class detailRepository
    {
        private context _context;
        public detailRepository(context _context)
        {
            this._context = _context;
        }

        public async Task<Guid> Create(double alpha1, double Sigma, double D1, double N,
            double u, double Dmin_Sigma, double N_V, double beta, string Material, string Material_P)

        {
            Guid id = Guid.NewGuid();
            var det = new detail(alpha1, Sigma, D1, N, u, Dmin_Sigma, N_V, beta, Material, Material_P)
            {
                Id = id,
            };
            await _context.AddAsync(det);
            await _context.SaveChangesAsync();
            return id;
        }
    }
}
