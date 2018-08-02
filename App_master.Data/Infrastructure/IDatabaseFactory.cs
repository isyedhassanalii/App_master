using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_master.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        DataContext Get();
    }
}
