using Autofac;

namespace Praxent.Email
{
    public static class Bootstrapper
    {
        public static ContainerBuilder AddEmailSystem(this ContainerBuilder builder)
        {
            builder.RegisterType<TransactionEmailContext>().As<ITransactionEmailContext>();
            builder.RegisterType<TransactionalEmailManager>().As<ITransactionalEmailManager>();

            return builder;
        }
    }
}