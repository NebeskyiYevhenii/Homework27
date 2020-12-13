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
    public class MyTransactionTypeService
    {
        private readonly MyTransactionsTypeRepository _myTransactionsTypeRepository;
        private readonly IMapper _mapper;


        public MyTransactionTypeService()
        {
            _myTransactionsTypeRepository = new MyTransactionsTypeRepository();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MyTransactionTypeModel, MyTransactionType>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }


        public MyTransactionTypeModel CreateMyTransactionType(MyTransactionTypeModel type)
        {
            var TransType = _mapper.Map<MyTransactionType>(type);
            _myTransactionsTypeRepository.CreatMyTransactionType(TransType);
            return type;
        }

        public MyTransactionTypeModel GetById(int id)
        {
            var Type = _myTransactionsTypeRepository.GetById(id);

            return _mapper.Map<MyTransactionTypeModel>(Type);
        }

        public bool DelById(int id)
        {
            return _myTransactionsTypeRepository.DelById(id);
        }

        public IEnumerable<MyTransactionTypeModel> GetAll()
        {
            IEnumerable<MyTransactionType> Types = _myTransactionsTypeRepository.GetAll();
            return _mapper.Map<IEnumerable<MyTransactionTypeModel>>(Types);
        }
    }
}
