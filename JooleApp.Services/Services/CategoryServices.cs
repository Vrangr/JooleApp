using JooleApp.Domain;
using JooleApp.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleApp.Services.Services
{
    public class CategoryServices : ICategoryServices
    {
        private IRepository<tblCategory> categoryRepository;

        public CategoryServices(IRepository<tblCategory> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }


        public IEnumerable<tblCategory> GetCategories()
        {
            return categoryRepository.GetAll();
        }

        public tblCategory GetCategory(int id)
        {
            return categoryRepository.GetbyId(id);
        }

        public void InsertCategory(tblCategory category)
        {
            categoryRepository.Insert(category);
        }
        public void UpdateCategory(tblCategory category)
        {
            categoryRepository.Update(category);
        }

        public void DeleteCategory(int id)
        {
            tblCategory category = categoryRepository.GetbyId(id);
            categoryRepository.Remove(category);
            categoryRepository.Save();
        }

    }
}
