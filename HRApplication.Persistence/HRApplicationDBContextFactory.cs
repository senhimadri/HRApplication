using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApplication.Persistence;

public class HRApplicationDBContextFactory : IDesignTimeDbContextFactory<HRApplicationDBContext>
{
    public HRApplicationDBContext CreateDbContext(string[] args)
    {
        throw new NotImplementedException();
    }
}

