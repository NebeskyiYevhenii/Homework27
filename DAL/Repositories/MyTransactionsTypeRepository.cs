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
    public class MyTransactionsTypeRepository : IMyTransactionsTypeRepository
    {
        private readonly ExpendituresALevelContext _ctx;

        public MyTransactionsTypeRepository()
        {
            _ctx = new ExpendituresALevelContext();
        }


        public MyTransactionType CreatMyTransactionType(MyTransactionType myTransactionType)
        {
            _ctx.MyTransactionTypes.Add(myTransactionType);
            _ctx.SaveChanges();
            return myTransactionType;
        }

        public bool DelById(int id)
        {
            try
            {
                var entity = _ctx.MyTransactionTypes.FirstOrDefault(x => x.Id == id);

                _ctx.MyTransactionTypes.Remove(entity);

                _ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<MyTransactionType> GetAll()
        {
            return _ctx.MyTransactionTypes.ToList();
        }

        public MyTransactionType GetById(int id)
        {
            return _ctx.MyTransactionTypes.FirstOrDefault(x => x.Id == id);
        }
    }
}
