using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class EFQuotesRepository : IQuotesRepository
    {
        public QuotesDbContext _context { get; set; }

        public EFQuotesRepository(QuotesDbContext temp)
        {
            _context = temp;
        }
        public IQueryable<Quote> Quotes => _context.Quotes;

        public void SaveQuote(Quote q)
        {
            _context.SaveChanges();
        }

        public void CreateQuote(Quote q)
        {
            _context.Add(q);
            _context.SaveChanges();
        }

        public void EditQuote(Quote q)
        {
            _context.Update(q);
            _context.SaveChanges();
        }

        public void DeleteQuote(int quoteid)
        {
            var quote = _context.Quotes.Single(x => x.QuoteID == quoteid);
            _context.Quotes.Remove(quote);
            _context.SaveChanges();
        }
    }
}
