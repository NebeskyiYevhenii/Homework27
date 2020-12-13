using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    interface IMyTransactionsTypeRepository
    {
        MyTransactionType CreatMyTransactionType(MyTransactionType myTransactionType);
        MyTransactionType GetById(int id);
        bool DelById(int id);
        IEnumerable<MyTransactionType> GetAll();
    }
}
