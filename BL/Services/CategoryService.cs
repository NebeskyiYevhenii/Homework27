using AutoMapper;
using BL.Models;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class CategoryService
    {
        private readonly ICategoriesRepository _catogoriesRepository;
        private readonly IMapper _mapper;


        public CategoryService()
        {
            _catogoriesRepository = new CatogoriesRepository();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CategoryModel, Category>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }

        public CategoryModel CreateCategory(CategoryModel category)
        {
            var cat = _mapper.Map<Category>(category);
            _catogoriesRepository.CreatCategory(cat);
            return category;
        }

        public CategoryModel GetById(int id)
        {
            var Ticket1 = _catogoriesRepository.GetById(id);

            return _mapper.Map<CategoryModel>(Ticket1);
        }

        public bool DelById(int id)
        {
            return _catogoriesRepository.DelById(id);
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            IEnumerable<Category> cat = _catogoriesRepository.GetAll();
            return _mapper.Map<IEnumerable<CategoryModel>>(cat);
        }

    }
}
