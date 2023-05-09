using BLL_BuisnessLogicLayer;
using BuisnessLogicLayer;
using DAL_DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Numerics;
using Universe.Models;
using Universe.Models.galaxy;
using Universe.Models.planet;
using Universe.Models.star;

namespace Projekt_xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void BLLTest()
        {

        var planets = new List<Planet>{
         new Planet { Id = 1, Name = "Planet A", Mass = 10 },
         new Planet { Id = 2, Name = "Planet B", Mass = 5 },
         new Planet { Id = 3, Name = "Planet C", Mass = 15 }
        };

            var fakeRepository = new FakeRepository<Planet>();

            foreach (var p in planets)
            {
                fakeRepository.Insert(p);
            }

            TestUnitOfWork unitOfWork = new TestUnitOfWork();
            unitOfWork.AddRepository(fakeRepository);
            var service = new Service(unitOfWork);
            var result = service.GetHeaviestPlanet();
            Assert.Equal(planets.ElementAt(2).Id, result.Result.Id);
        }
        [Fact]
        public void MockTest()
        {
            var mockRepo = new MockEntityRepository<Planet>().MockCountAsync(3).MockGetByID(new Planet { Id = 1, Name = "Planet A", Mass = 10 });
            var unitOfWork = new UnitOfWork();
            unitOfWork.AddRepository(mockRepo.Object);
            var service = new Service(unitOfWork);
            var result = service.GetAllPlanetsCount();
            Assert.Equal(3, result.Result);
        }
        public static DbUniverse GetTestDbContext(string dbName)
        {
            // Create db context options specifying in memory database
            var options = new DbContextOptionsBuilder<DbUniverse>()
            .UseInMemoryDatabase(databaseName: dbName)
            .Options;

            //Use this to instantiate the db context
            return new DbUniverse(options);

        }

        private DbUniverse GetTestDatabase()
        {
            var testContext = GetTestDbContext(nameof(AddRandomStarsTest));
            return testContext;
        }

        [Fact]
        public void AddRandomStarsTest()
        {
            var testContext = GetTestDatabase();
            var starsRepo = new Repository<Star>(testContext);
            var unitOfWork = new TestUnitOfWork();
            unitOfWork.AddRepository(starsRepo);
            var service = new Service(unitOfWork);
            var count = 1;
            var result = service.AddRandomStars(count);
            Assert.Equal(count, unitOfWork.GetRepository<Star>().GetList().Count());
        }
    }
}