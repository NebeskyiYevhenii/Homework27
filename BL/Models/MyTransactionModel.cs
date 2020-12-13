using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class MyTransactionModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Currency { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public int MyTransactionTypeModelId { get; set; }
        public MyTransactionTypeModel MyTransactionTypeModel { get; set; }

        public int CategoryModelId { get; set; }
        public virtual CategoryModel CategoryModel { get; set; }
    }
}
