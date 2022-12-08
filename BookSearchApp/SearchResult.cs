using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSearchApp
{
    public class SearchResult
    {
        public string libraryName { get; }
        public string libraryAddress { get; }
        public string bookState { get; }

        public SearchResult(string libraryName, string libraryAddress, string bookState)
        {
            this.libraryName = libraryName;
            this.libraryAddress = libraryAddress;
            this.bookState = bookState;
        }
    }
}
