using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class MyTransactionType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<MyTransaction> MyTransactions { get; set; }
    }
}
