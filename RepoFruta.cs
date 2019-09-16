using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruta
{
    class RepoFruta
    {
        public void Mostrar_Fruta(Fruta Object)
        {
            Console.WriteLine("Numero de fruta: {0}\tNombre: {1}\tTipo: {2}\tPeso; {3}Gr\tPrecio: ${4}\t\n",
                Object.Id, Object.Nombre, Object.Tipo, Object.Precio, Object.Peso);
        }
        public void Listar_Fruta(Fruta[] frutas)
        {
            foreach (Fruta Object in frutas)
            {
                Console.WriteLine("Numero de fruta: {0}\tNombre: {1}\tTipo: {2}\tPeso; {3}Gr\tPrecio: ${4}\t\n",
                    Object.Id, Object.Nombre, Object.Tipo, Object.Precio, Object.Peso);
            }
        }
        public void Vender_Fruta(Fruta[] frutas)
        {
            int Cantidad;
            decimal Precio_Total = 0;
            decimal Precio_Final = 0;
            decimal Peso_Total;
            string Respuesta = "";

            do
            {
                foreach (Fruta x in frutas)
                {
                    Console.WriteLine("Ingrese la cantidad de {0}", x.Nombre);
                    Cantidad = Int32.Parse(Console.ReadLine());

                    Precio_Total = Cantidad * x.Precio;
                    Peso_Total = Cantidad * x.Peso;

                    Console.WriteLine("Numero de fruta: {0}\tNombre: {1}\tTipo: {2}\tPeso; {3}Gr\tPrecio: ${4}\t\n",
                    x.Id, x.Nombre, x.Tipo, x.Peso, x.Precio, Cantidad, Precio_Total, Peso_Total);

                    Precio_Final = Precio_Total + Precio_Final;
                }
                Console.WriteLine("El precio final de la compra es de: $" + Precio_Final + "\n");
                Console.WriteLine("Desea registrar alguna otra venta?: ");
                Respuesta = Console.ReadLine();
            } while (Respuesta != "no");
        }
    }
}
