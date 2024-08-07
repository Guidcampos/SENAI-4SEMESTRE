using Moq;
using ProdutoApiTest.Domains;
using ProdutoApiTest.Interface;
using ProdutoApiTest.Repositories;

namespace ProdutosApiTestUnit
{
    public class ProductsTest
    {
        /// <summary>
        /// Teste para a funcionalidade de listar todos os produtos
        /// </summary>
        [Fact]

        public void Get()
        {
            //Arrange

            //lista de produtos
            List<Products> productList = new List<Products>
            {
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 1", Price = 78 },
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 2", Price = 90 },
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 3", Price = 787 }

            };

            //Cria um objeto de simulação do tipo ProductRepository
            var mockRepository = new Mock<IProductsRepository>();
            //Configura o metodo Get para que retorne a lista mockada
            mockRepository.Setup(x => x.Get()).Returns(productList);

            //Act
            //Executando o metodo Get e atribui a resposta em result 
            var result = mockRepository.Object.Get(); 

            //Assert
            Assert.Equal(3, result.Count );
        }

        [Fact]
        public void Post() 
        {
            //lista de produtos
            List<Products> productList = new List<Products>();
            Products product = new Products { IdProduct = Guid.NewGuid(), Name = "TESTE", Price = 100 };

            var mockRepository = new Mock<IProductsRepository>();
            mockRepository.Setup(x => x.Post(product)).Callback<Products>(x => productList.Add(product));
            
            mockRepository.Object.Post(product);

            Assert.Contains(product, productList);


        }

        [Fact]
        public void Delete()
        {
            //lista de produtos
            List<Products> productList = new List<Products>
            {
                new Products { IdProduct = Guid.Parse("fc072692-d322-448b-9b1b-ba3443943579"), Name = "Produto 1", Price = 78 },
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 2", Price = 90 },
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 3", Price = 787 }

            };

            Products product = new Products { IdProduct = Guid.Parse("fc072692-d322-448b-9b1b-ba3443943579"), Name = "Produto 1", Price = 78 };
            var idbuscado = Guid.Parse("fc072692-d322-448b-9b1b-ba3443943579");


            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Delete(idbuscado)).Callback<Guid>(x => productList.Remove(productList.FirstOrDefault(s => s.IdProduct == idbuscado)));


            mockRepository.Object.Delete(idbuscado);

            Assert.DoesNotContain(product, productList);

        }

        [Fact]

        public void GetId() 
        {
            //lista de produtos
            List<Products> productList = new List<Products>
            {
                new Products { IdProduct = Guid.Parse("fc072692-d322-448b-9b1b-ba3443943579"), Name = "Produto 1", Price = 78 },
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 2", Price = 90 },
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 3", Price = 787 }

            };

            var idbuscado = Guid.Parse("fc072692-d322-448b-9b1b-ba3443943579");

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.GetById(idbuscado)).Returns(productList.FirstOrDefault(a => a.IdProduct == idbuscado));
            var result = mockRepository.Object.GetById(idbuscado);

            Assert.Equal(idbuscado, result.IdProduct);

        }

        [Fact]

        public void Update ()
        {
            //lista de produtos
            List<Products> productList = new List<Products>
            {
                new Products { IdProduct = Guid.Parse("fc072692-d322-448b-9b1b-ba3443943579"), Name = "Produto 1", Price = 78 },
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 2", Price = 90 },
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 3", Price = 787 }

            };

            Products product = new Products { IdProduct = Guid.Parse("fc072692-d322-448b-9b1b-ba3443943579"), Name = "Teste", Price = 78 };
            var idbuscado = Guid.Parse("fc072692-d322-448b-9b1b-ba3443943579");


            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Put(product.IdProduct, product)).Callback<Guid, Products>((id, p) =>
            {
                var item = productList.FirstOrDefault(x => x.IdProduct == id);

                if (item != null)
                {
                    item.Name = p.Name;
                    item.Price = p.Price;
                }
            });

            mockRepository.Object.Put(product.IdProduct, product);
            var updatedProduct = productList.FirstOrDefault(x => x.IdProduct == idbuscado);

            Assert.Equal("Teste", updatedProduct.Name);

        }

    }
}