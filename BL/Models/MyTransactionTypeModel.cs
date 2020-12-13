using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class MyTransactionTypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<MyTransactionModel> MyTransactionModels { get; set; }
    }
}
