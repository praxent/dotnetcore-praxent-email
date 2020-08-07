using Praxent.Email.Model;

namespace Praxent.Email
{
    public interface ITransactionalEmailManager
    {
        void SendTransactionalEmail(TransactionalEmail transactionalEmail);
        void SendTransactionalEmailWithBaseURL(TransactionalEmail transactionalEmail);

    }
}