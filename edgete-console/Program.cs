namespace edgete_console
{
    using System.Reflection;
    using Common.Logging;
    using System;
    using System.Threading.Tasks;
    using EdgeJs;



    class Program
    {
        /// <summary>
        ///     The Log (Common.Logging)
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static async Task Start()
        {
            var func = Edge.Func(@"
            return function (data, callback) {
                callback(null, 'Node.js welcomes ' + data);
            }
        ");

            Console.WriteLine(await func(".NET"));
        }

        static void Main(string[] args)
        {
            Start().Wait();
        }
    }
}
