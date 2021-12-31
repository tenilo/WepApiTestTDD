using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAwokie.Domain
{
    public interface ISelfieRepository
    {
        ICollection<Selfie> GetAll();
    }
}
