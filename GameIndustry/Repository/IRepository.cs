using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameIndustry.Models;

namespace GameIndustry.Repository
{
    interface IRepository
    {
        Task<List<Game>> GetAll();
    }
}
