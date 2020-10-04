using System;
using Xunit;
using apidemo.Controllers;
using Microsoft.Extensions.Logging;

namespace apidemo.Test
{
    public class UnitTest1
    {

        static ILogger<ValuesController> _logger ;
        ValuesController controller = new ValuesController(_logger);

        [Fact]
        public void GetReturnMyName(){

            var returnview = controller.Get(1);

            Assert.Equal("maher ben issa", returnview.ToString()); 

 
        }

        [Fact] 
        public void Test1()
        {

        }
    }
}
