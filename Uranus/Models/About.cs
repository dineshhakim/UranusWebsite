using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Uranus.Domain.Entities;

namespace Uranus.Models
{
    public class About
    {
        public IEnumerable<TeamMember> TeamMembers { get; set; }

        public IEnumerable<Customer> Customers { get; set; }

        public About(IEnumerable<TeamMember> teamMembers, IEnumerable<Customer> customers)
        {
            TeamMembers = teamMembers;
            Customers = customers;
        }

    }
}