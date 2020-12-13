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
    public class MyTransactionService
    {
        private readonly IMyTransactionsRepository _myTransactionsRepository;
        private readonly IMapper _mapper;
    

        public MyTransactionService()
        {
            _myTransactionsRepository = new MyTransactionsRepository();
        
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MyTransactionModel, MyTransaction>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }


        public MyTransactionModel CreateMyTransaction(MyTransactionModel Transaction)
        {
            var Trans = _mapper.Map<MyTransaction>(Transaction);
            _myTransactionsRepository.CreatMyTransaction(Trans);
            return Transaction;
        }

        public MyTransactionModel GetById(int id)
        {
            var Transaction = _myTransactionsRepository.GetById(id);

            return _mapper.Map<MyTransactionModel>(Transaction);
        }

        public bool DelById(int id)
        {
            return _myTransactionsRepository.DelById(id);
        }

        public IEnumerable<MyTransactionModel> GetAll()
        {
            IEnumerable<MyTransaction> Transaction = _myTransactionsRepository.GetAll();
            return _mapper.Map<IEnumerable<MyTransactionModel>>(Transaction);
        }

    }
}
