using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        class Cliente
        {
            //Estas seran las caracteristicas del cliente, todos los datos generales
            private string nombre;
            private string pedido1; //Los clientes tienen un limite de dos pedidos
            private string pedido2;
            private int costo; //Costo por ambos pedidos

            public Cliente(string nom) //Se almacenan los datos de los clientes
            {
                nombre = nom;
                pedido1 = "";
                pedido2 = "";
                costo = 0;
            }

            public void Orden1(string ord) //Se almacenan en un String el vehiculo que el cliente pidio
            {
                 pedido1 = ord;
            }

            public void Orden2(string ord) //Se almacenan en un String el vehiculo que el cliente pidio
            {
                pedido2 = ord;
            }

            public void Pagar(int m) //Aqui se almacena el costo total del pedido
            {
                costo = costo + m;
            }

            public void Eliminar(int m) //Si se hace un cambio, este proceso elimina el pedido
            {
                costo = costo - m;
            }

            public void Imprimir() //Aqui se imprimen todos los datos del cliente
            {
                Console.WriteLine($"{nombre} ha pedido:\n{pedido1}\n{pedido2}\nLo que costara: {costo}");
            }
        }
        class Vehiculo
        {
            private String tipos;
            private String marcas;
            private String modelo;
            private int costo;
            public Vehiculo(String tipo, String marca, String modelo, int costo)
            {
                tipos = tipo;
                marcas = marca;
                modelo = this.modelo;
                costo = this.costo;
            }
        }

        class Agencia
        {
            private Cliente cliente1, cliente2, cliente3;//Funciones sin delimitar
            private Vehiculo carro1, carro2, camion1, camion2, moto1, moto2;

            public Agencia()
            {
                //Funciones sin delimitar
                cliente1 = new Cliente("Yhonas");
                cliente2 = new Cliente("Ana");
                cliente3 = new Cliente("Pedro");
                carro1 = new Vehiculo("Carro","Mercedes-Benz","Maybach S 650",4040000);
                carro2 = new Vehiculo("Carro","Mercedes-Benz","C 300 Convertible",1010000);
            }
            
            public void Comprar()
            {
                //Funciones sin delimitar

            }
            
            public void Eliminar()
            {
                //Funciones sin delimitar
                Console.Clear();
                Console.WriteLine("Pulse una tecla para salir");
                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                int opcion;
                //Funciones sin delimitar
                do {
                    Console.WriteLine("---------------MENU------------------");
                    Console.WriteLine("-        1. Checar Cliente          -");
                    Console.WriteLine("- 2. Verificar Carros en la Agencia -");
                    Console.WriteLine("-       3. Eliminar Factura         -");
                    Console.WriteLine("-       4. Comprar Vehiculo         -");
                    Console.WriteLine("-             5. Salir              -");
                    Console.WriteLine("-------------------------------------");
                    opcion = int.Parse(Console.ReadLine());
                } while (opcion !=4);
                if (opcion==1)
                    {
                        
                    }
                else if (opcion==2)
                    {
                        
                    }
                else if (opcion==3)
                    {
                        
                    }
                else if(opcion==4)
                    {
                        
                    }
                Console.ReadKey();
            }
        }
    }
}
