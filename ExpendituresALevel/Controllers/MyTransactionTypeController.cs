using AutoMapper;
using BL.Models;
using BL.Services;
using ExpendituresALevel.Models.PostModel;
using System.Web.Mvc;

namespace ExpendituresALevel.Controllers
{
    public class MyTransactionTypeController : Controller
    {
        private readonly MyTransactionTypeService _myTransactionTypeService;
        private readonly IMapper _mapper;


        public MyTransactionTypeController()
        {
            _myTransactionTypeService = new MyTransactionTypeService();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MyTransactionTypePostModel, MyTransactionTypeModel>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }



        // GET: MyTransactionType
        public ActionResult Index()
        {
            return View();
        }
    }
}