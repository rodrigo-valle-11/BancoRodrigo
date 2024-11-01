namespace BancoRodrigo.Models
{
    public class Investment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
        public int DurationDays { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InvestmentType { get; set; } // Puede ser 'Corta' o 'Larga'
    }
}
