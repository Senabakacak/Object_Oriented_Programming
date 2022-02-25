using Abstract2.Model.Entities.Abstract;
using Abstract2.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2.Model.Entities.Concrete
{
    public class AppUser:BaseEntity<int>
    {
        public override int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName=>$"{FirstName} {LastName}";
        public Role Role { get; set; }
    }
}
