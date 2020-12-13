using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpendituresALevel.Models.PostModel
{
    public class MyTransactionTypePostModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<MyTransactionPostModel> MyTransactionsPostModel { get; set; }
    }
}