// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityTest.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Summary description for UnitTest1
// </summary>
// --------------------------------------------------------------------------------------------------------------------


namespace Entity
{
    using System;
    using System.Data.Objects;

    using HelloEntityFramework.Data.Dal;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test unidad de entidades.
    /// </summary>
    [TestClass]
    public class EntityTest
    {
        /// <summary>
        /// Test Context.
        /// </summary>
        private TestContext testContextInstance;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityTest"/> class.
        /// </summary>
        public EntityTest()
        {
            return;
        }

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }

            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /// <summary>
        /// Test Product Entity.
        /// </summary>
        [TestMethod]
        public void TestProducts()
        {
            Random random = new Random();
            using (TutorialEntities tutorialEntities = new TutorialEntities())
            {
                Product product = new Product();
                product.IdProduct = random.Next(100000, 999999).ToString("000000");
                Console.WriteLine("Producto '{0}' agregado.", product.IdProduct);
                
                tutorialEntities.AddToProducts(product);
                tutorialEntities.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);
            }
        }
    }
}
