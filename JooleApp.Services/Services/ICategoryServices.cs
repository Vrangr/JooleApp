using JooleApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleApp.Services.Services
{
    public interface ICategoryServices
    {
        IEnumerable<tblCategory> GetCategories();

        tblCategory GetCategory(int id);

        void InsertCategory(tblCategory category);

        void UpdateCategory(tblCategory category);
        void DeleteCategory(int id);
    }
}
