namespace BancoRodrigo.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
        public int DurationDays { get; set; }
        public string PaymentMethod { get; set; } // Mensual o Fin de la inversión
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
