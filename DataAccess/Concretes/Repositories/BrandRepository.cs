using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.Repositories;

public class BrandRepository : IBrandRepository
{
    private BaseDbContext _baseDbContext;

    public BrandRepository(BaseDbContext baseDbContext)
    {
        _baseDbContext = baseDbContext;
    }

    public void Add(Brand brand);
}
