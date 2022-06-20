using System;

namespace Ecommerce.Herança
{
    public interface IPedidoService : IBaseService<Pedido>
    {
         void FecharPedido(int id);
         Pedido DetalhesPedido(int id);
        
    }
}