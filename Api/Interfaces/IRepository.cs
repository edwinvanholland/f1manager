using BlazorApp.Shared.Models;
using System.Collections.Generic;

namespace Api.Interfaces
{
    public interface IRepository
    {

        List<RaceDriver> GetDrivers();
        List<RaceTeam> GetTeams();
        List<Circuit> GetCircuits();
        void UpdateRaceStats(List<QualifyResult> results);
    }
}