using DAL.Contexts;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CatogoriesRepository : ICategoriesRepository
    {

        private readonly ExpendituresALevelContext _ctx;

        public CatogoriesRepository()
        {
            _ctx = new ExpendituresALevelContext();
        }


        public Category CreatCategory(Category category)
        {
            _ctx.Catogories.Add(category);
            _ctx.SaveChanges();
            return category;
        }

        public bool DelById(int id)
        {
            try
            {
                var entity = _ctx.Catogories.FirstOrDefault(x => x.Id == id);

                _ctx.Catogories.Remove(entity);

                _ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return _ctx.Catogories.ToList();
        }

        public Category GetById(int id)
        {
            return _ctx.Catogories.FirstOrDefault(x => x.Id == id);
        }
    }
}
