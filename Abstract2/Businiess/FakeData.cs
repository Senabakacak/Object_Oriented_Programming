using Abstract2.Model.Entities.Concrete;
using Abstract2.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2.Businiess
{
    public static  class FakeData
    {
        public static List<AppUser> AppUsers = new List<AppUser>()
        {
            new AppUser{Id= 1, FirstName="Lily",LastName="Rose",Role=Role.Admin,UpdateDate=null,DeleteDate=null},

            new AppUser { Id = 2, FirstName = "Sophia", LastName = "Jenner", Role = Role.Admin, UpdateDate = null, DeleteDate = null },

            new AppUser { Id = 3, FirstName = "Tom", LastName = "Grint", Role = Role.Manager, UpdateDate = null, DeleteDate = null }

        };
    }
}
