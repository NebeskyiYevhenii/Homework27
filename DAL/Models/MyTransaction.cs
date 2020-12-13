using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class MyTransaction
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Currency { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public int MyTransactionTypeId { get; set; }
        public MyTransactionType MyTransactionType { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
