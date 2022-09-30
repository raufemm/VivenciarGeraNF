using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;
using VivenciarGenerateOrder.Infra.IRepository;
using VivenciarGenerateOrder.Infra.Repository;

namespace VivenciarGenerateOrder.Infra.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Professional = new ProfessionalRepository(_context);
            Patient = new PatientRepository(_context);
        }

        public IProfessionalRepository Professional { get; private set; }
        public IPatientRepository Patient { get; private set; }

        public void Save()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }
    }
}
