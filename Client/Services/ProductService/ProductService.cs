using BlazingShop.Shared;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>
            {
               new Product{
                  Id = 1,
                  CategoryId = 1,
                  Title = "Superman",
                  Description = "Superman has power",
                  Image = "https://th.bing.com/th/id/R.2e9d1a1fe34bd659a00482d80f757066?rik=hkqf1Gjvt7tBFg&riu=http%3a%2f%2fwww.nerdreport.com%2fwp-content%2fuploads%2f2020%2f05%2fb5eaa3aad6d866a8282a9d67bb5ecfc2.jpg&ehk=VW5ucndaNsH6xY1ying1birDRuxH45MZ39QRDp1KuyE%3d&risl=&pid=ImgRaw&r=0",
                  Price = 9.99m,
                  OrginalPrice = 19.99m,
               },
               new Product{
                  Id = 2,
                  CategoryId = 3,
                  Title = "Spiderman",
                  Description = "Spiderman is a humen spider",
                  Image = "https://nl.letsgodigital.org/uploads/2019/08/nieuwe-spiderman-film-770x508.jpg",
                  Price = 8.99m,
                  OrginalPrice = 29.99m,
               },

            };
        }
    }
}
