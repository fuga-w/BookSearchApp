using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSearchApp
{
    public class BookSearcher
    {
        public BookSearcher() { }

        /// <summary>
        /// todo: 実装中
        /// </summary>
        /// <returns></returns>
        public List<SearchResult> Search()
        {
            
            var tmpData = new List<SearchResult>();
            var tnp = new SearchResult("test_name", "test_address", "貸し出し可");
            tmpData.Add(tnp);

            return tmpData;
        }
    }
}
