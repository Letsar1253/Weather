using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Server.DatabaseProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Server.DatabaseProvider
{
    public class ContextManager
    {
        private readonly WeatherAppDbContext _context;

        internal ContextManager(WeatherAppDbContext context)
        {
            _context = context;
        }

        public async Task Save<T>(IEnumerable<T> entities) where T : class
        {
            await _context.Set<T>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAsync<T>(Expression<Func<T, bool>> predicate) where T : class =>
            await _context.Set<T>().Where(predicate).ToListAsync();

        public async Task<IEnumerable<T>> FindAsync<T>(Expression<Func<T, bool>> predicate, string navigationProperty) where T : class =>
            await _context.Set<T>().Where(predicate).Include(navigationProperty).ToListAsync();
    }
}
