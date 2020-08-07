namespace Praxent.Email
{
    public interface ITransactionEmailContext
    {
        string SystemEmailSender { get; }
        string SystemEmailReplyTo { get; }
        string SiteBaseUrl { get; }
    }
}