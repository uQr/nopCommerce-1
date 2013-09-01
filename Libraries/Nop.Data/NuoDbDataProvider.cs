using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Nop.Data.Initializers;
using NuoDb.Data.Client;
using NuoDb.Data.Client.EntityFramework;

namespace Nop.Data
{
    public class NuoDbDataProvider : BaseEfDataProvider
    {
        public override IDbConnectionFactory GetConnectionFactory()
        {
            return new NuoDbConnectionFactory();
        }

        public override void SetDatabaseInitializer()
        {
            Database.SetInitializer(new NuoDbDatabaseInitializer<NopObjectContext>());
        }

        public override bool StoredProceduredSupported
        {
            get { return false; }
        }

        public override DbParameter GetParameter()
        {
            return new NuoDbParameter();
        }
    }
}
