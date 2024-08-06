using ControleDeInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleDeInventario.Controle;

namespace ControleInventario.Test
{
    public class ControleUnitTest
    {
        [Fact]
        public static void VerificarItemAdd()
        {
            var produto1 = new Produto();

            produto1.Nome = "Computador";
            produto1.Quantidade = 1;

            List<Produto> lista = new List<Produto>();

            var resultado1 = Controle.AdicionarProduto(lista, produto1);

            var verQuantidade1 = lista.FirstOrDefault(x => x.Nome == "Computador");

            Assert.NotNull(resultado1 );

            var produto2 = new Produto();
            produto2.Nome = "Computador";

            var resultado2 = Controle.AdicionarProduto(lista, produto2 );

            var verQuantidade2 = lista.FirstOrDefault(x => x.Nome == "Computador");

            Assert.Equal(2, verQuantidade2.Quantidade);
        }
    }
}
