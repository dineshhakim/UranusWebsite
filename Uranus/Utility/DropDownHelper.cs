using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Uranus.Utility
{
    public class DropDownHelper
    {
        public static IEnumerable<SelectListItem> FillddlOrganizationType()
        {
            var list = new List<string>
            {
                "Cooperative",
                "Microfinance",
                "Finance",
                "Development Bank",
                "WholeSale Lending"
            };
            var roles = list.Select(role =>
                  new SelectListItem
                  {
                      Text = role,
                      Value = role
                  }); ;
            return roles;

        }

    }
}