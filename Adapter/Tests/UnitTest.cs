using AdapterDP;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class UnitTest
    {       


        [OneTimeSetUp]
        public void Init()
        {        

        }

        [OneTimeTearDown]
        public void Dispose()
        {         
        }

        [Test]
        public void A()
        {

            RandomGenerator rn = new RandomGenerator() { Amount = 1000, LowerLimit = 0, HigherLimit = 1000 };
            int[] result = rn.Calculate();
            Assert.AreEqual(result.Length, 1000);

        }

        [Test]
        public void B()
        {
            // Lazy initialization. The object is built only when the value property is invoked
            Lazy<RandomGenerator> rn = new Lazy<RandomGenerator>();
            rn.Value.Amount = 1000;
            rn.Value.LowerLimit = 0;
            rn.Value.HigherLimit = 1000;
            int[] result = rn.Value.Calculate();
            Assert.AreEqual(result.Length, 1000);
        }

        [Test]
        public void C()
        {
            //Arrange
            Mock<IPerson> mockPerson = new Mock<IPerson>();
            mockPerson.SetupGet(m => m.FirstName).Returns("Diego");
            mockPerson.SetupGet(m => m.LastName).Returns("Burlando");
            mockPerson.Setup(m => m.FullName()).Returns("Diego Burlando");
            mockPerson.Setup(m => m.GetPersonInfo("78629AD")).Returns("This is a good customer");


            IPerson p = mockPerson.Object;      

            Assert.AreEqual(p.FirstName, "Diego");
            Assert.AreEqual(p.LastName, "Burlando");
            Assert.AreEqual(p.FullName(), "Diego Burlando");
            Assert.AreEqual(p.GetPersonInfo("78629AD"), "This is a good customer");

        }

        [Test]
        public void D()
        {
            //Arrange
            Mock<IRepository> mockRepo = new Mock<IRepository>();
            mockRepo.Setup(m => m.GetPerson(It.IsAny<string>())).Returns
                (                
                    new Person() {  FirstName="TestName", LastName="TestLastName"}                
                );         

            Order TestOrder = new Order(mockRepo.Object, It.IsAny<string>());
            var ret = TestOrder.Info();
            Assert.AreEqual(TestOrder.Info(), "TestName TestLastName Has Bought 100 Computers");

            mockRepo.VerifyAll();
        }

      

        [Test]
        public void E()
        {
          
        }


    }
}
