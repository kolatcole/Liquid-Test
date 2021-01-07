using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3
{
    public interface IService
    {
        Task<IEnumerable<Nltran>> getAll();
    }
}
