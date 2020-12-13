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
    public class MyTransactionsRepository : IMyTransactionsRepository
    {

        private readonly ExpendituresALevelContext _ctx;

        public MyTransactionsRepository()
        {
            _ctx = new ExpendituresALevelContext();
        }




        public MyTransaction CreatMyTransaction(MyTransaction myTransaction)
        {
            _ctx.MyTransactions.Add(myTransaction);
            _ctx.SaveChanges();
            return myTransaction;
        }

        public bool DelById(int id)
        {
            try
            {
                var entity = _ctx.MyTransactions.FirstOrDefault(x => x.Id == id);

                _ctx.MyTransactions.Remove(entity);

                _ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<MyTransaction> GetAll()
        {
            return _ctx.MyTransactions.ToList();
        }

        public MyTransaction GetById(int id)
        {
            return _ctx.MyTransactions.FirstOrDefault(x => x.Id == id);
        }
    }
}
