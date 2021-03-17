using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413_Project_one.Models
{
    public interface IGroupRepository
    {
        IQueryable<Group> Groups { get; }

    }
}