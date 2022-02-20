using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Businiess.Repositories.Abstract
{
    public abstract class BaseRepository<T>
        //Repository pattern
        //herhangi bir entity için CRUD işlemlerini yaparken yardımcı olarak methodları ve fonksiyonları tutar.

    {
        public abstract void Create(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);  
        public abstract List<T> GetAll();
        public abstract T GetById(int id);
        public abstract T GetById(Guid guid);



    }
}
