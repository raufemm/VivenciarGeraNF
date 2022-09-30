using VivenciarGenerateOrder.Domain.Entities;
using VivenciarGenerateOrder.Infra.Context;
using VivenciarGenerateOrder.Infra.IRepository;

namespace VivenciarGenerateOrder.Infra.Repository
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
