﻿using API.Controllers;
using BLL_BuisnessLogicLayer;
using Microsoft.AspNetCore.Mvc;
using Moq;
using TestingBLL.Controllers;
using Tests_xUnit.FakeClasses;
using Universe.Models.planet;

namespace Tests_xUnit
{
	public class APITests1 
	{
		// 1
		[Fact]
		public void GetAllPlanetsCountTest()
		{
            // Arrange
            Mock<IService> mockBLL = new Mock<IService>(); //var mockRepo = new Mock<IBrainstormSessionRepository>();
            mockBLL.Setup(s => s.GetAllPlanetsCount()).Returns(3); //mockRepo.Setup(repo => repo.ListAsync()).ReturnsAsync(GetTestSessions());
            var serviceController = new ServiceAPIController(mockBLL.Object); //var controller = new HomeController(mockRepo.Object);
            // Act
            var result = serviceController.GetAllPlanetsCount(); //var result = await controller.Index();
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<int>(viewResult.ViewData.Model);
            Assert.Equal(3, model);

        }
		// 3.1
		[Fact]
		public void APIRandomStarsTest()
		{
			var mockService = new MockService();
			var serviceAPIController = new ServiceAPIController(mockService);
			var count = 6;
			serviceAPIController.AddRandomStars(count);
			Assert.Equal(count, mockService.StarCount);
		}
		// 3.2
		[Fact]
		public void APIGetHeaviestPlanetTest()
		{
			var mockService = new Mock<IService>();
			var p = new Planet
			{
				Id = 1
			};
			mockService.Setup(m => m.GetHeaviestPlanet()).Returns(p);
			var serviceAPIController = new ServiceAPIController(mockService.Object);
			var result = serviceAPIController.GetHeaviestPlanet();
			//Assert.Equal<Planet>(p, result);
		}
	}
}
