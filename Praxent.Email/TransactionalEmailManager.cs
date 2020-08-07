using Praxent.Email.Model;

namespace Praxent.Email
{
    public class TransactionalEmailManager : ITransactionalEmailManager
    {
        private readonly ITransactionEmailContext _transactionEmailContext;

        public TransactionalEmailManager(ITransactionEmailContext transactionEmailContext)
        {
            _transactionEmailContext = transactionEmailContext;
        }

        public void SendTransactionalEmail(TransactionalEmail transactionalEmail)
        {
            var message = CreateNewMailMessage();

            message.Subject = transactionalEmail.Subject;
            message.ToEmailList.Add(transactionalEmail.EmailAddress);
            message.MergeValues = transactionalEmail.MergeValuesForTemplate;

            //TODO: Send Email with basic SMTP
        }

        private MailMessage CreateNewMailMessage()
        {
            var message = new MailMessage
            {
                FromEmail = _transactionEmailContext.SystemEmailSender,
                ReplyTo = _transactionEmailContext.SystemEmailReplyTo
            };

            return message;
        }
        public void SendTransactionalEmailWithBaseURL(TransactionalEmail transactionalEmail)
        {
            transactionalEmail.MergeValuesForTemplate.Add("BASE_URL", _transactionEmailContext.SiteBaseUrl);
            SendTransactionalEmail(transactionalEmail);
        }
    }
}