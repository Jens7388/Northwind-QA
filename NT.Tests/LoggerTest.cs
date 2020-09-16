using Microsoft.VisualStudio.TestTools.UnitTesting;

using NT.Logging;
using System;
using System.Threading.Tasks;

namespace NT.Tests
{
    [TestClass]
    public class LoggerTest
    {
        [TestMethod]
        public static async Task LogMessageAsyncTest()
        {
           await Logger.LogAsync("test");
        }

        [TestMethod]
        public static async Task LogExeptionAsyncTest()
        {
           Exception ex = new NullReferenceException();
           await Logger.LogAsync(ex);
        }
    }
}