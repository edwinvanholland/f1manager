using BlazorApp.Shared.Models;
using System.Collections.Generic;

namespace Api.Interfaces
{
    public interface IRepository
    {

        public List<RaceDriver> GetDrivers();
        public List<RaceTeam> GetTeams();
        public List<Circuit> GetCircuits();
    }
}