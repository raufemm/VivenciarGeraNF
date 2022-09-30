namespace VivenciarGenerateOrder.Domain.Entities
{
    public class Professional : Person
    {
        public bool Active { get; private set; }

        public void Create(string name)
        {
            FullName = name;
            Active = true;
            CreatedAt = System.DateTime.Now;
            LastUpdate = System.DateTime.Now;
        }
    }
}
