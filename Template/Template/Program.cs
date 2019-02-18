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

        class Agencia
        {
            private Cliente cliente1, cliente2, cliente3;//Funciones sin delimitar

            public Agencia()
            {
                //Funciones sin delimitar
                cliente1 = new Cliente("Yhonas");
                cliente2 = new Cliente("Ana");
                cliente3 = new Cliente("Pedro");
            }

            public void Comprar()
            {
                //Funciones sin delimitar
            }

            public void Eliminar()
            {
                //Funciones sin delimitar
            }

            static void Main(string[] args)
            {
                //Funciones sin delimitar
                Console.ReadKey();
            }
        }
    }
}
