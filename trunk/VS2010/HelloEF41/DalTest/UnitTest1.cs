using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DalTest
{
    [TestClass]
    public class TestUser
    {
        [TestMethod]
        public void InitializeDatabse()
        {
            HelloContext helloContext = new HelloContext();
            HelloContextInitializaer helloContextInitializaer = new HelloContextInitializaer();
            helloContextInitializaer.InitializeDatabase(helloContext);
        }

        [TestMethod]
        public void TestCreate()
        {

            HelloContext helloContext = new HelloContext();

            User user = new User();
            user.Nombre = "Nico";

            Movement movement = new Movement();
            movement.CreationTime = DateTime.Now;

            user.Movements.Add(movement);
            

            helloContext.Users.Add(user);

            helloContext.SaveChanges();
        }

        [TestMethod]
        public void TestGet()
        {
            HelloContext helloContext = new HelloContext();
            User user = helloContext.Users.Include("Movements").First();

            Assert.AreEqual(typeof(User), user.GetType());
        }
    }
}
