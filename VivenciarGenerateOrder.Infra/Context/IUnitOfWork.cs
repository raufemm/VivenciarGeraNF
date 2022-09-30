using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;
using VivenciarGenerateOrder.Infra.IRepository;

namespace VivenciarGenerateOrder.Infra.Context
{
    public interface IUnitOfWork : IDisposable
    {
        IProfessionalRepository Professional { get; }
        IPatientRepository Patient { get; }
        void Save();
        Task SaveAsync();
        Task<IDbContextTransaction> BeginTransactionAsync();
        IDbContextTransaction BeginTransaction();
    }
}
