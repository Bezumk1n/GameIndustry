using GameIndustry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustry.Repository
{
    public class GameRepository : IRepository
    {
        private List<Game> _games;
        public GameRepository()
        {
            _games = new List<Game>()
        {
            new Game()
            {
                Name="Farming simulator 2019",
                Genre="Simulator",
                ReleaseDate=new DateTime(2018, 11, 19)
            },
            new Game()
            {
                Name="The Witcher 3",
                Genre="Action/RPG",
                ReleaseDate=new DateTime(2015, 5, 18)
            },
            new Game()
            {
                Name="Destroy all humans",
                Genre="Action/Adventure",
                ReleaseDate=new DateTime(2020, 07, 28)
            },
        };
        }
        public async Task<List<Game>> GetAll()
        {
            return _games;
        }
    }
}
