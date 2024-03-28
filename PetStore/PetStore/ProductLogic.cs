namespace PetStore
{

    internal class ProductLogic
    {
        private List<Product> _products = new();
        private Dictionary<string, DogLeash> _dogLeashes = new();
        private Dictionary<string, CatFood>  _catFoods = new();



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
            return _dogLeashes[name];
        }
    }
}
