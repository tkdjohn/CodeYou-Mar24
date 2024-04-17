namespace PetStore
{

    internal class ProductLogic
    {
        private List<Product> _products = [];
        private readonly Dictionary<string, DogLeash> _dogLeashes = [];
        private readonly Dictionary<string, CatFood> _catFoods = [];



        public ProductLogic()
        {

        }


        public void AddProduct(Product product) 
        { 
            _products.Add(product);

            if (product is DogLeash)
            {
                _dogLeashes.Add(product.Name, product as DogLeash);
            }

            if (product is CatFood)
            {
                _catFoods.Add(product.Name, product as CatFood);
            }
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return _dogLeashes[name];
            }
            catch (Exception ex)
            {
                return null; 
            }
        }
    }
}
