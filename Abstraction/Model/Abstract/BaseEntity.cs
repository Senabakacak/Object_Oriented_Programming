using Abstraction.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Model.Abstract
{
    public abstract class BaseEntity<T> //generic  type
    {
        public abstract T Id { get; set; } //abstract işaretli override edilmeli farklı farklı kullanmak için
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate
        {
            get { return _createDate; }

            set { _createDate = value; }

        }
        private Status _status = Status.Active;
        public Status Status
        { 
            get { return _status; }
            set { _status = value; }
        }


    }
}
