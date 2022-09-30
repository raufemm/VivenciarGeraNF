namespace VivenciarGenerateOrder.Domain.Entities
{
    public class Patient : Person
    {
        public string NationalRegister { get; protected set; }
        public bool Discharged { get; protected set; }
        public virtual Sponsor Sponsor { get; protected set; }
        public Professional ResponsiblePsychologist { get; protected set; }
    }
}
