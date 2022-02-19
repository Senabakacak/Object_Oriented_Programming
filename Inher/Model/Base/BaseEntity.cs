using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inher.Model.Base
{
    enum Status //enum:sabitleri tutar,index değeri verebiliriz
    {
        Active=1,
        Modified=2,
        Passive=3
    }
     class BaseEntity
     {
        public int Id { get; set; }
        public string Name { get; set; }

        private DateTime _createdate=DateTime.Now; //sistem saatini tutucak
        //encapsüle ettik

        public DateTime CreateDate
        {
            get { return _createdate; }//dış erişime kapalı olan değeri dışarı çıkardık
            set { _createdate = value; } //dışarıdan gelen değeri createdate atadık
        }

        public Status _status=Status.Active;

        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }
     }
}
