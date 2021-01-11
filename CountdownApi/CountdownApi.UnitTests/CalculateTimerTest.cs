using NUnit.Framework;
using System.Threading;

namespace CountdownApi.UnitTests
{
    [TestFixture]
    public class Tests
    {
           //CountdownModelsController countdownModelsController;
           //ContactRepository repository;
           
           //int count;
           //int contactId;
           
           [SetUp]
           public void Setup()
           {
               //create an instance of contactRepository
               /*repository = new ContactRepository();
               
               //Create an instance of controller by passing repository
               contactsController = new ContactsController(repository);
               
               //Number of records
               count = contactsController.Get().contacts.Count;
               
               //Pass contact ID and store the retrieved contact ID
               contactId = contactsController.Get(1).contact.Id;*/
           }
    
           [Test]
           public void CalculateTimerTest()
           {
            //Arrange 
            int time = 23;
            int number = 23;
            int expectedTime = 22;
            //Act
            CountdownApi.Utils.Timer.CalculateNumber(number, ref time);
            Thread.Sleep(1000);
            //Assert
             Assert.AreEqual(time, expectedTime);
           }
    }
}
