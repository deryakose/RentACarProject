using Business.Requests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public class IModelService
{
    Task<CreateModelResponce> AddAsync(CreateModelRequest request);
    Task<List<GetAllModelResponce>>
}
