using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspenlaub.Net.GitHub.CSharp.ChabStandard.Test {
    [TestClass]
    public class OvenTest {
        [TestMethod]
        public void CanBakeACake() {
            var container = new ContainerBuilder().UseChabStandard().Build();
            var sut = container.Resolve<IOven>();
            var cake = sut.BakeACake();
            Assert.IsNotNull(cake);
        }
    }
}
