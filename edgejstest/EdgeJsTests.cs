using System;
using System.Reflection;
using System.Threading.Tasks;
using Common.Logging;
using EdgeJs;
using NUnit.Framework;


// ReSharper disable MemberCanBePrivate.Global

// ReSharper disable once CheckNamespace

namespace edgejstest
{
    /// <summary>
    ///     EdgeJs Tests
    /// </summary>
    [TestFixture]
    public class EdgeJsTests
    {
        /// <summary>
        ///     SetUp is called once before each Test within the same TestFixture
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            Log.Debug("SetUp");
            }

        /// <summary>
        ///     The Log (Common.Logging)
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static async Task Start()
        {
            Log.Debug("Start Enter");

            Log.Debug("Gettin' funcy.");

            // Next line hangs
            var func = Edge.Func(@"
        return function (data, callback) {
            callback(null, 'hello world');
        }
    ");

            Log.Debug("all func'd up. :)");

            Console.WriteLine(await func(".NET"));
        }

        /// <summary>
        ///     Evaluate Simple Javascript
        /// </summary>
        [Test]
        [Category("EdgeJs")]
        // [RequiresThread]
        public void Eval_Tests()
        {
            Log.Debug("Eval_Tests Enter");
            

            Start().Wait();
        }
    }
}