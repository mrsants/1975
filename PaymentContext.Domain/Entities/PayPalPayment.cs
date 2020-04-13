namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionCode) :
         base(
             number,
             paidDate,
             expireDate,
             total,
             totalPaid,
             payer,
             document,
             address,
             email)
        {
            this.TransactionCode = transactionCode;
        }
        public string TransactionCode { get; private set; }


    }
}