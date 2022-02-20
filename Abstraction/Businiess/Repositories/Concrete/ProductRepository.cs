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
    public class ProductRepository : BaseRepository<Product>
    {
        public override void Create(Product entity)
        {
            FakeData.Products.Add(entity);//kullanıcının eklemek istediği productı fakedataya ekledik
        }

        public override void Delete(Product entity)
        {
            entity.Status = Model.Status.Passive; //veritabanından veri silinmez buyüzden passive çektik
        }

        public override List<Product> GetAll()
        {
            //Fake veritabanımızda ki ürünlerimizi listeleyen fonksiyon
            var productList = FakeData.Products.ToList();
            return productList;
        }

        public override Product GetById(int id)
        {
            Product findedProduct = new Product();

            foreach (Product product in FakeData.Products)
            {
                if (product.Id == id)
                {
                    findedProduct = product;
                }
            }

            return findedProduct;
        }

        public override Product GetById(Guid guid)
        {
            throw new NotImplementedException();
        }

        public override void Update(Product entity)
        {
            Product product = GetById(entity.Id);//update edilmek istenilen entity yakaladık

            //Kullancııdan gelen bilgiyi bize paramtre aracılığıyal yani "entity" üzerinden geldi. 
            //Burada kullanıcıdan gelen bilgileri güncellemek istediğimiz ürünümüzün alanlarına yazdırdık.
            product.Name = entity.Name;
            product.Description = entity.Description;
            product.Price = entity.Price;
            product.Status = Model.Status.Modified;
            product.Stock = entity.Stock;
        }
    }
}
