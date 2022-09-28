namespace Udemy.BankApp.Web.Models
{
    public class SendMoneyModel
    {
        public int SenderId { get; set; }
        public int AccountId { get; set; }
        public decimal Amount { get; set; }
    }
}
