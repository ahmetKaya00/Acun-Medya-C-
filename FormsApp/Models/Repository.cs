namespace FormsApp.Models{

    public class Repository{

        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository(){
            _categories.Add(new Category{CategoryId = 1, Name = "Telefon"});
            _categories.Add(new Category{CategoryId = 2, Name = "Bilgisayar"});

            _products.Add(new Product{ProductId = 1, Name = "Iphone 15", Price = 80000, Image = "3.jpg",CategoryId=1, IsActive = true});
            _products.Add(new Product{ProductId = 2, Name = "Iphone 15 Pro Max", Price = 100000, Image = "4.jpg",CategoryId=1, IsActive = true});
            _products.Add(new Product{ProductId = 3, Name = "Mac Book", Price = 80000, Image = "1.jpg",CategoryId=2, IsActive = true});
            _products.Add(new Product{ProductId = 4, Name = "Mac Book Air", Price = 90000, Image = "2.jpeg",CategoryId=2, IsActive = true});
        }

        public static List<Product> Products{get{return _products;}}

        public static void CreateProduct(Product entity){
            _products.Add(entity);
        }

        public static void EditProduct(Product updateProduct){
            var entity = _products.FirstOrDefault(p=>p.ProductId == updateProduct.ProductId);

            if(entity != null){
                if(!string.IsNullOrEmpty(updateProduct.Name)){
                entity.Name = updateProduct.Name;
                }
                entity.Price = updateProduct.Price;
                entity.Image = updateProduct.Image;
                entity.IsActive = updateProduct.IsActive;
                entity.CategoryId = updateProduct.CategoryId;
            }
        }

        public static void EditIsActive(Product updateProduct){
            var entity = _products.FirstOrDefault(p=>p.ProductId == updateProduct.ProductId);

            if(entity != null){
                entity.IsActive = updateProduct.IsActive;
            }
        }

        public static void DeleteProduct(Product entity){
            var PrdEntity = _products.FirstOrDefault(p=>p.ProductId == entity.ProductId);
            if(PrdEntity != null){
                _products.Remove(PrdEntity);
            }
        }
        public static List<Category> Categories{get{return _categories;}}

    }
}