using ExpendituresALevel.Models.PostModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpendituresALevel.Models.Category
{
    public class CategoryPostModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Title { get; set; }

        public ICollection<MyTransactionPostModel> MyTransactions { get; set; }
    }
}