namespace VivenciarGenerateOrder.Domain.Entities
{
    public class Sponsor : Person
    {
        public bool Company { get; protected set; }
        public string NationalRegister { get; set; } //CNPJ or CPF in Brazil
    }
}
