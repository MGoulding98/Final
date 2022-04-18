using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public interface IQuotesRepository
    {
        IQueryable<Quote> Quotes { get; }

        public Quote GetQuote(int quoteid);
        public void SaveQuote(Quote q);
        public void CreateQuote(Quote q);
        public void EditQuote(Quote q);
        public void DeleteQuote(int quoteid);
    }
}
