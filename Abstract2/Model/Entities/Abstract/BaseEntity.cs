using Abstract2.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2.Model.Entities.Abstract
{
    public abstract  class BaseEntity<T>
    {
        public abstract T Id { get; set; }

        DateTime _createDate=DateTime.Now;
        public DateTime CreateDate
        { get => _createDate;
            
          set=>_createDate = value;
        }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public Status _status = Status.Active;

        public Status Status
        {
            get => _status;
            set => _status = value; 
        }


    }
}
