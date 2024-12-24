using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }
       
        
        
        
        
        
        
        


        
        public virtual void save() => _context?.SaveChanges();
        public void Dispose() => _context?.Dispose();

    }
    
}
