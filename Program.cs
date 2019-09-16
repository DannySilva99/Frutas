using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruta
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruta a = new Fruta();
            Fruta b = new Fruta();
            Fruta c = new Fruta();
            Fruta[] Frutas = { a, b, c };

            a.Id = 664;
            a.Nombre = "Manzana";
            a.Tipo = "Washington";
            a.Peso = 500;
            a.Precio = 5;

            b.Id = 663;
            b.Nombre = "Banana";
            b.Tipo = "Macho";
            b.Peso = 200;
            b.Precio = 7;

            c.Id = 662;
            c.Nombre = "Pera";
            c.Tipo = "Olmo";
            c.Peso = 300;
            c.Precio = 6;

            RepoFruta Op = new RepoFruta();

            Op.Mostrar_Fruta(a);
            Op.Listar_Fruta(Frutas);
            Op.Vender_Fruta(Frutas);
        }
    }
}
