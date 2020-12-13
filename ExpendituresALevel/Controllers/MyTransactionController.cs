using AutoMapper;
using BL.Models;
using BL.Services;
using ExpendituresALevel.Models.PostModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpendituresALevel.Controllers
{
    public class MyTransactionController : Controller
    {
        private readonly MyTransactionService _myTransactionService;
        private readonly IMapper _mapper;


        public MyTransactionController()
        {
            _myTransactionService = new MyTransactionService();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MyTransactionPostModel, MyTransactionModel>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }






        // GET: MyTransaction
        public ActionResult Index()
        {
            return View();
        }
    }
}