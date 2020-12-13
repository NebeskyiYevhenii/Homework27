using ExpendituresALevel.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpendituresALevel.Models.PostModel
{
    public class MyTransactionPostModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Currency { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public int MyTransactionTypeId { get; set; }
        public MyTransactionTypePostModel MyTransactionTypePostModel { get; set; }

        public int CategoryId { get; set; }
        public virtual CategoryPostModel CategoryPostModel { get; set; }
    }
}