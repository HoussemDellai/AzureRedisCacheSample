using StackExchange.Redis;
using System;

namespace AzureRedisCacheConsoleDemo
{
    class Program
    {

        private static Lazy<ConnectionMultiplexer> _lazyConnection = new Lazy<ConnectionMultiplexer>(
            () => { return ConnectionMultiplexer.Connect("senelec.redis.cache.windows.net:6380,password=nJWmd4RdwHfM6ww1bhsgfHcm+ZJiurSucfGOThw8NU0=,ssl=True,abortConnect=False"); }
        );

        public static ConnectionMultiplexer Connection => _lazyConnection.Value;

        static void Main(string[] args)
        {
            IDatabase cache = Connection.GetDatabase();

            cache.StringSet("houssem-key1", "J'aime Dakar :)");
            
            var value1 = cache.StringGet("houssem-key1");
        }
    }
}
