using Microsoft.Extensions.Configuration;

namespace Praxent.Email
{
    public class TransactionEmailContext : ITransactionEmailContext
    {
        private readonly IConfiguration _configuration;

        public TransactionEmailContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string SystemEmailSender { get { return _configuration.GetValue<string>("SYSTEM_EMAIL_SENDER"); } }
        public string SystemEmailReplyTo { get { return _configuration.GetValue<string>("SYSTEM_EMAIL_REPLY_TO"); } }
        public string SiteBaseUrl { get { return _configuration.GetValue<string>("SITE_BASE_URL"); } }
    }
}