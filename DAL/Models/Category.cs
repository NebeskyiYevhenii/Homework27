using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Category
    {
        public int Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime UpdateDate { get; set; }
        string Title { get; set; }

        public ICollection<MyTransaction> MyTransactions { get; set; }

    }
}
