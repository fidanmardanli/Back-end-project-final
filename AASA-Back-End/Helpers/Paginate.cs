using AASA_Back_End.Models;
using System.Collections.Generic;

namespace AASA_Back_End.Helpers
{
    public class Paginate<T>
    {
        private IEnumerable<Product> products;
        private int page;
        private int count;

        public IEnumerable<Product> Datas { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }


        public Paginate(IEnumerable<Product> datas, int currentPage, int totalPage)
        {
            Datas= products;
            CurrentPage= currentPage;
            TotalPage = totalPage;
        }

      
    }
}
