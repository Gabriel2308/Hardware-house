using Hardware_house.Domain.DTO;
using Hardware_house.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_house.Infra.CrossCutting.Mapper
{
    public class ItemMapper
    {
        public Item DtoToItem(ItemDTO itemDTO)
        {
            Item item = new Item();

            item.CarrinhoId = itemDTO.CarrinhooId;
            item.IdServicos = itemDTO.ServicoId;
            item.ProdutosId = itemDTO.ProdutoId;

            return item;
        }

        public ItemDTO ItemToDTO(Item item)
        {
            ItemDTO itemDTO = new ItemDTO();

            itemDTO.CarrinhooId = item.CarrinhoId;
            itemDTO.ServicoId = item.IdServicos;
            itemDTO.ProdutoId = item.ProdutosId;

            return itemDTO;
        }
    }
}
