using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICategoriesRepository
    {
        Category CreatCategory(Category category);
        Category GetById(int id);
        bool DelById(int id);
        IEnumerable<Category> GetAll();
    }
}
