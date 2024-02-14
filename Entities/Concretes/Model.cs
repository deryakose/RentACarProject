using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Model:BaseEntity<int>
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public string Name { get; set; }
    public virtual Brand? Brand { get; set; }


    public Model()
    {
        
    }

    public Model(int id, int brandId, string name)
    {
        Id = id;
        BrandId = brandId;
        Name = name;
  
    }
}
