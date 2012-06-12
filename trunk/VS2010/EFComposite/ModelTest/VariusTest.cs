using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using EFComposite.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFComposite.ModelTest
{
    [TestClass]
    public class VariusTest
    {
        public VariusTest()
        {
            using (ExampleContext exampleContext = new ExampleContext())
            {
                // Populate Silo Warehouse
                Island silo = new Island();
                silo.Name = "Silo";

                exampleContext.Positions.Add(silo);

                // Populate Picking Warehouse
                Island picking = new Island();
                picking.Name = "Picking";

                exampleContext.Positions.Add(picking);

                exampleContext.SaveChanges();

                // Populate aisles
                Dictionary<int, Aisle> aisles = new Dictionary<int, Aisle>();
                for (int i = 1; i <= 5; i++)
                {
                    Aisle aisle = new Aisle();
                    aisle.AisleNumber = i;
                    aisle.Name = "Pasillo " + i;
                    aisle.ParentPosition = silo;
                    aisles.Add(i, aisle);

                    exampleContext.Positions.Add(aisle);
                }

                exampleContext.SaveChanges();

                // Populate silo location
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        for (int k = 1; k <= 5; k++)
                        {
                            SiloLocation siloLocation = new SiloLocation();
                            siloLocation.CoordX = i;
                            siloLocation.CoordY = j;
                            siloLocation.CoordP = k;
                            siloLocation.Name = "S" + i + j + k;
                            siloLocation.ParentPosition = aisles[i];

                            exampleContext.Positions.Add(siloLocation);
                        }
                    }
                }

                exampleContext.SaveChanges();
            }
        }

        [TestMethod]
        public void TestSiloLocation()
        {
            using (ExampleContext exampleContext = new ExampleContext())
            {
                // Silo location total assert
                IQueryable<SiloLocation> siloLocations = exampleContext.Positions.OfType<SiloLocation>();
                Assert.AreEqual(125, siloLocations.Count());

                // Aisle total assert
                IQueryable<Aisle> aisles = exampleContext.Positions.OfType<Aisle>();
                Assert.AreEqual(5, aisles.Count());

                // Get Aisle location
                Aisle aisle = exampleContext.Positions.OfType<Aisle>().FirstOrDefault(a => a.AisleNumber == 1);
                Assert.IsNotNull(aisle);

                // Get all locations in asile
                exampleContext.Entry(aisle).Collection( a => a.ChildPositions).Load();
                Assert.AreEqual(25, aisle.ChildPositions.Count);

                //Get silo location
                SiloLocation siloLocation = exampleContext.Positions.OfType<SiloLocation>().FirstOrDefault(s => s.CoordX == 1 && s.CoordY == 1 && s.CoordP == 1);
                Assert.IsNotNull(siloLocation);

                // Get aisle of location
                exampleContext.Entry(siloLocation).Reference(s => s.ParentPosition).Load();
                Assert.IsTrue(siloLocation.ParentPosition is Aisle);
                Assert.AreEqual(1, ((Aisle)siloLocation.ParentPosition).AisleNumber);

                // Get Warehouse of location I
                Aisle aisle2 = (Aisle)siloLocation.ParentPosition;
                exampleContext.Entry(aisle2).Reference(a => a.ParentPosition).Load();
                Assert.AreEqual("Silo", aisle2.ParentPosition.Name);

                // Get Warehouse of location II
                SiloLocation siloLocation2 = exampleContext.Positions.OfType<SiloLocation>().Include(s => s.ParentPosition.ParentPosition).FirstOrDefault(s => s.CoordX == 1 && s.CoordY == 1 && s.CoordP == 1);
                Assert.IsNotNull(siloLocation2);
                Assert.AreEqual("Silo", siloLocation2.ParentPosition.ParentPosition.Name);

                // Get all location of warehouse
                var silolocations = exampleContext.Positions.Where(p => p.ParentPosition.ParentPosition.Name == "Silo");
                Assert.AreEqual(125, silolocations.Count());

            }
        }

        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ExampleContext>());
        }

    }
}
