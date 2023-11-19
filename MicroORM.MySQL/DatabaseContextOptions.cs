using Microsoft.Extensions.Options;

namespace MicroORM.MySQL
{
    public class DatabaseContextOptions : IOptions<DatabaseContextOptions>
    {
        public string ConnectionString { get; set; }

        DatabaseContextOptions IOptions<DatabaseContextOptions>.Value
        {
            get { return this; }
        }
    }
}
