using Microsoft.EntityFrameworkCore;
using SelfieAwokie.Domain;
using SelfieAwookie.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAwookie.Infrastructure.Repositories
{
    public class SelfieRepostory : ISelfieRepository
    {
        #region properties
        private readonly SelfieContext _context;
        #endregion
        #region constructor
        public SelfieRepostory(SelfieContext context)
        {
            _context = context;
        }

        #endregion
        public ICollection<Selfie> GetAll()
        {
            return this._context.Selfies.Include(item => item.Wookie).ToList();
        }
    }
}
