using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebGame.Content.ItemGeneration
{
    public abstract class UseableItem : Item
    {
        #region Properties
        public List<OnUseEffects> OnUseEffects { get; set; }
        #endregion

        #region Overrides
        public override void EquipItem()
        {
            throw new InvalidOperationException();
        }

        public override void Log()
        {
            throw new NotImplementedException();
        }

        public override void RemoveItem()
        {
            throw new NotImplementedException();
        }

        public override void SellItem()
        {
            throw new NotImplementedException();
        }

        public override void UseItem()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}