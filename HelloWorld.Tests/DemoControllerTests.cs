namespace HelloWorld.Tests
{
    using System;
    using Xunit;
    using Microsoft.AspNetCore.Mvc;
    using HelloWorld.Controllers;

    public class DemoControllerTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void TestDummy(int value)
        {
            DemoController controller = new DemoController();
            string result = controller.Dummy(value);
            string exp = $"id++={value + 1}";
            Assert.Equal(exp, result);
        }
    }
}
