using Axis.DataAccess.IRepository;
using Axis.DataAccess.Persistence;
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

        #region Repositories
        public ICompanyRepository Companies { get; private set; }

        #endregion
        public UnitOfWork(
            AxisDbContext context,
            ICompanyRepository companyRepository
            )


        {
            _context = context;
            Companies = companyRepository;
        }
       
        
        
        
        
        
        
        


        
        public virtual void save() => _context?.SaveChanges();
        public void Dispose() => _context?.Dispose();

    }
    
}
