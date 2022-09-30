using VivenciarGenerateOrder.Domain.Entities;
using VivenciarGenerateOrder.Infra.Context;
using VivenciarGenerateOrder.Infra.IRepository;

namespace VivenciarGenerateOrder.Infra.Repository
{
    public class ProfessionalRepository : GenericRepository<Professional>, IProfessionalRepository
    {
        public ProfessionalRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
