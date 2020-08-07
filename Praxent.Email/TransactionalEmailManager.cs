using Praxent.Email.Model;

namespace Praxent.Email
{
    public class TransactionalEmailManager : ITransactionalEmailManager
    {
        public void SendTransactionalEmail(TransactionalEmail transactionalEmail)
        {
            var message = new MailMessage
            {
                FromEmail = transactionalEmail.FromEmail,
                ReplyTo = transactionalEmail.ReplyTo,
                Subject = transactionalEmail.Subject,
                MergeValues = transactionalEmail.MergeValuesForTemplate
            };

            message.ToEmailList.Add(transactionalEmail.EmailAddress);
            message.MergeValues = transactionalEmail.MergeValuesForTemplate;

            //TODO: Send Email with basic SMTP
            //https://docs.microsoft.com/en-us/dotnet/api/system.net.mail.smtpclient?view=netcore-3.1
        }
    }
}