using Maratony.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maratony.UI
{
    class MaratonyEntities : DbContext
    {
        public DbSet<Zawody> ZawodyBase { get; set; }
        public DbSet<Biegacz> BiegaczeBase { get; set; }

    }
    
}
