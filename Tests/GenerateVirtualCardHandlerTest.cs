using Domain.Commands.Inputs;
using Domain.Commands.Results;
using Domain.Handlers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class GenerateVirtualCardHandlerTest
    {
        [TestMethod]
        public void MustReturnValidEmail()
        {
            GenerateVirtualCardCommand command = new GenerateVirtualCardCommand();
            command.Email = "jhonatanfernandes.com";

            GenerateVirtualCardHandler handler = new GenerateVirtualCardHandler();
            GenerateVirtualCardCommandResult result = handler.Handle(command);
            
            //Assert.IsNotNull(result);
            Assert.AreEqual(result, typeof(string));
        }

        [TestMethod]
        public void MustReturnSuccess()
        {
            GenerateVirtualCardCommand command = new GenerateVirtualCardCommand();
            command.Email = "jhonatanfernandes.com";

            GenerateVirtualCardHandler handler = new GenerateVirtualCardHandler();
            GenerateVirtualCardCommandResult result = handler.Handle(command);

            //Assert.IsNotNull(result);
            Assert.AreEqual(result, typeof(GenerateVirtualCardCommandResult));
        }
    }
}
