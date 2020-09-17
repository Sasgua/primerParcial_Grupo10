using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial_Grupo10
{
    class Program
    {
       
        
        

        static void Main(string[] args)
        {
            int opc, total, contador, descuento1, descuento2;

            int UltiOpc;
            
            contador = 0;

            do
            {

                Console.WriteLine("Camisas PRADBIT – Ventas minoristas y mayoristas");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("MENÚ PRINCIPAL: \n1 - Añadir camisa al carro de compras \n2 - Eliminar camisa del carro de compras \n3 - Salir");
                Console.WriteLine("Ingrese una opción del menú:");
                opc = int.Parse(Console.ReadLine());

                // esta es la opcion de salida por si el usuario desea cerrar el programa 
                if (opc == 3)
                {
                    Console.WriteLine("¿Esta seguro que desea salir? 1.SI / 2.NO ");
                    UltiOpc = int.Parse(Console.ReadLine());
                    if (UltiOpc <= 1)
                    {
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        opc = 4;
                    }
                   
                }

                switch (opc)
                {
                    case 1:

                        contador++;
                        
                        break;
                    case 2:

                        contador--;

                        break;
                }

                // aca estan las condiciones que tiene el programa segun las compras de las camisas  

                total = contador * 1000;
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("- Cantidad de camisas en el carro de compras: < {0} > \n-Precio unitario: $1000", contador);
                if (contador >= 3 && contador <= 5)
                {
                    descuento1 = (10 * total) / 100;
                    Console.WriteLine("- Precio total sin descuento: ${0} \n-Tipo de descuento aplicado: %10 ", total);
                    Console.WriteLine("-Precio final con descuento: $ " + descuento1);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                }
                else if (contador > 5)
                {
                    descuento2 = (20 * total) / 100;
                    Console.WriteLine("- Precio total sin descuento: ${0} \n-Tipo de descuento aplicado: %20 ", total);
                    Console.WriteLine("-Precio final con descuento: $ " + descuento2);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("- Precio total sin descuento: ${0} \n-Tipo de descuento aplicado: %0 ", total);
                    Console.WriteLine("-Precio final con descuento: $ " + total);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                }
                if (contador < 0)
                {
                    Console.WriteLine("Usted no puede tener un cantidad negativa de camisas");
                    Console.ReadKey();
                }

            } while (opc != 3);



            Console.ReadKey();
        }

      
        
    }
}
