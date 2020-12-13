using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IMyTransactionsRepository
    {
        MyTransaction CreatMyTransaction(MyTransaction myTransaction);
        MyTransaction GetById(int id);
        bool DelById(int id);
        IEnumerable<MyTransaction> GetAll();
    }
}
