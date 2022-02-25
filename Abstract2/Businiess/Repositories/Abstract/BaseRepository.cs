using Abstract2.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract2.Businiess.Repositories.Abstract
{
    public abstract class BaseRepository<T>
    {
        public abstract void Create(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);

        public abstract List<T> GetAll();

        public abstract T GetById(int id);
        public abstract List<T> GetByRole(Role role);
        public abstract List<T> GetByLastName(string lastName);

        public abstract void GetRoles(ComboBox comboBox);
    }
}
