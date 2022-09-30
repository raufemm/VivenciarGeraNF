using VivenciarGenerateOrder.Domain.Commom;

namespace VivenciarGenerateOrder.Domain.Entities
{
    public abstract class Person : Entity
    {
        public string FullName { get; protected set; }
        public string Phone { get; protected set; }
        public virtual Address Address { get; protected set; }
    }
}
