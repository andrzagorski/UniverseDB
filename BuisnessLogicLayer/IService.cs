﻿using Universe.Models.discoverer;
using Universe.Models.galaxy;
using Universe.Models.planet;
using Universe.Models.ship;
using Universe.Models.starsystem;

namespace BLL_BuisnessLogicLayer
{
    public interface IService
    {
        int GetAllPlanetsCount();
        int GetAllStarsCount();
        IQueryable<StarSystem> GetAllStarSystems();
        IQueryable<Galaxy> GetAllGalaxies();
        IQueryable<Ship> ShowAllShips();
        Planet GetHeaviestPlanet();
        Task AddRandomStars(int count);
        Task MoveStarSystemToAnotherGalaxy(int starSystemId, int galaxyId);
        Task MakeNewShip(int MaxRange, int MaxSpeed, string? model = null, int? discovererID = null);
        Task HireNewDiscoverer(string name, string surname, int age);
        Task RewardExplorerByNewShip(int discovererID, string shipModel, string shipName, int maxSpeed, int singleChargeRange);
        IQueryable<Discoverer> ShowDetailsDiscovererers();
        Task FireDiscoverer(int id);
    }
}
