using Hardware_house.Domain.DTO;
using Hardware_house.Infra.CrossCutting.Mapper;
using Hardware_house.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_house.Domain.Services
{
    public class ItemDomain
    {
        public ItemDTO ConsultarItemById(int id)
        {
            ItemRepository item = new ItemRepository();
            ItemMapper mapper = new ItemMapper();

            return mapper.ItemToDTO(item.GetItemByProdutoId(id));
        }
        public Object CriarNovoItem(ItemDTO itemDto)
        {
            ItemRepository item = new ItemRepository();
            ItemMapper mapper = new ItemMapper();

            return item.PostNewItem(mapper.DtoToItem(itemDto));
        }
        public Object DeletarItem(int id)
        {
            ItemRepository item = new ItemRepository();

            return item.DeleteItem(id);
        }
    }
}
