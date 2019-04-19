using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebGame.Content.Interfaces
{
    public interface IItemActions
    {
        void UseItem();
        void EquipItem();
        void RemoveItem();
        void SellItem();
    }
}
