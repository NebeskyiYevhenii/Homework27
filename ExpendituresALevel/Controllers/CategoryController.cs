using ExpendituresALevel.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using BL.Services;
using BL.Models;

namespace ExpendituresALevel.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryService;
        private readonly IMapper _mapper;


        public CategoryController()
        {
            _categoryService = new CategoryService();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CategoryPostModel, CategoryModel>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }










        // GET: Category
        public ActionResult Index()
        {
            // List<CategoryBl> servise.GetMyCategories()

            CategoryPostModel model = new CategoryPostModel
            {
                Id = 1,
                Title = "test"
            };

            return View("~/Views/Category/MyCategories.cshtml", model);
        }
    }
}