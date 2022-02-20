using Abstraction.Businiess.Data;
using Abstraction.Businiess.Repositories.Abstract;
using Abstraction.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Businiess.Repositories.Concrete
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public override void Create(Category entity)
        {
            FakeData.categories.Add(entity);
        }

        public override void Delete(Category entity)
        {
            foreach (Category category in FakeData.categories)
            {
                if (category.Id == entity.Id)
                {
                    category.Status = Model.Status.Passive;
                }
            }
        }

        public override List<Category> GetAll()
        {
            return FakeData.categories.ToList();
        }

        public override Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override Category GetById(Guid guid)
        {
            throw new NotImplementedException();
        }

        public override void Update(Category entity)
        {
            foreach (Category category in FakeData.categories)
            {
                if (category.Id == entity.Id)
                {
                    category.Name = entity.Name;
                    category.Description = entity.Description;
                    category.Status = Model.Status.Modified;
                }
            }
        }
    }
}
