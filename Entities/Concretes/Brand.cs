using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Brand:BaseEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Model> Model { get; set; }
    public Brand()
    {
        Models = new HashSet<Model>();
    }

    public Brand(int id, string name):this()
    {
        Id = id;
        Name = name;
    }
}
