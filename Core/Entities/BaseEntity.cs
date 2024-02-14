using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class BaseEntity<TId>
{
    public TId Id { get; set; }
    public DataSetDateTime CreatedDate { get; set; }
    public DataSetDateTime UpdatedDate { get;set; }
    public DataSetDateTime DeleteDate { get; private set; }
}
