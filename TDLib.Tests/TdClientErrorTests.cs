using System;
using System.Threading.Tasks;
using TdLib;
using Xunit;

namespace TDLib.Tests
{
    public class TdClientErrorTests
    {
        [Fact]
        public async Task Execute_WhenErrorExpected_ThrowsTdException()
        {
            using (var client = new TdClient())
            {
                TdException exception = null;
                try
                {
                    await client.ExecuteAsync(new TdApi.TestUseError());
                }
                catch (TdException e)
                {
                    exception = e;
                }
                
                Assert.NotNull(exception);
                Assert.NotNull(exception.Error);
            }
        }
    }
}