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

    public static class Repository
    {
        private static List<Group> responses = new List<Group>();
        public static IEnumerable<Group> Responses => responses;
        public static void AddResponse(Group response)
        {
            responses.Add(response);
        }
    }
}