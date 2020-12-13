using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime UpdateDate { get; set; }
        string Title { get; set; }

        public ICollection<MyTransactionModel> MyTransactionsModels { get; set; }
    }
}
