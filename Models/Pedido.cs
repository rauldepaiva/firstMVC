using System;
using System.Collections.Generic;

namespace at02.Models
{
    public class Pedido
    {
        private List<ItemPedido> listaPedidos = new List<ItemPedido>();

        public Pedido()
        {
            //listaPedidos = new List<ItemPedido>();
        }

        public void IncluirItem(ItemPedido item)
        {
            listaPedidos.Add(item);
        }

        public double TotalPedido()
        {
            double total = 0;

            foreach(ItemPedido item in listaPedidos)
            {
                total += item.Valor_unitario * item.Quantidade;
            }

            return total;
        }

        public List<ItemPedido> Listar()
        {
            return listaPedidos;
        }
    }
}