
using MongoDB.Driver;

namespace Sample.Database.Context
{
    public class ReadContext
    {
        protected ReadContext()
        {
            var Client = new MongoClient("mongodb+srv://<username>:<password>@<cluster-address>/test?w=majority");

            Database = Client.GetDatabase("SampleDB");
        }

        public IMongoDatabase Database { get; }
    }
}
