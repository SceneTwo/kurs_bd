using DataBaseStorage;
using DataBaseStorage.entities;

namespace DataBaseLogic.Repositories
{
    public class resultEntityRepository
    {
        private context _context;

        public resultEntityRepository(context _context)
        {
            this._context = _context;
        }

        public async void Create(double Sigma, double F, double Sigma0, double SigmaF, double Crossectionalarea, Guid detailId, Guid unitId)
        {
            Guid id = Guid.NewGuid();
            var resultE = new resultEntity(Sigma, F, Sigma0, SigmaF, Crossectionalarea)
            {
                Id = id,
                detailId = detailId,
                unitId = unitId,

            };
            await _context.AddAsync(resultE);
            await _context.SaveChangesAsync(); ;
        }
    }
}
