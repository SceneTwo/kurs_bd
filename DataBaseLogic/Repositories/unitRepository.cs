using DataBaseStorage;
using DataBaseStorage.entities;

namespace DataBaseLogic.Repositories
{
    public class unitRepository
    {
        private context _context;
        public unitRepository(context _context)
        {
            this._context = _context;
        }

        public async Task<Guid> Create(double F, double b, double Sigma0, double SigmaF0, double SigmaF, double C0,
                                       double C1, double C2, double C3, double W, string MezOs, string Natyazh,
                                       string Character, string TypeofMachine, string TypeofEngine, double A, double Crossectionalarea)
        {
            Guid id = Guid.NewGuid();
            var uni = new unit(F, b, Sigma0, SigmaF0, SigmaF, C0, C1, C2, C3, W, MezOs, Natyazh, Character, TypeofMachine, TypeofEngine, A, Crossectionalarea)
            {
                Id = id
            };
            await _context.AddAsync(uni);
            await _context.SaveChangesAsync();

            return id;
        }
    }

}
