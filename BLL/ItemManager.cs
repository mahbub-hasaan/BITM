using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BITM_Works.Repository;
using BITM_Works.Models;
using System.Data;
namespace BITM_Works.BLL
{
    class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public bool Add(Item item)
        {
            return _itemRepository.Add(item);
        }
        public bool IsNameExists(Item item)
        {
            return _itemRepository.IsNameExists(item);
        }

        public bool Delete(Item item)
        {
            return _itemRepository.Delete(item);
        }
        public DataTable Display()
        {
            return _itemRepository.Display();
        }
        public DataTable ItemCombo()
        {
            return _itemRepository.ItemCombo();
        }
    }
}
