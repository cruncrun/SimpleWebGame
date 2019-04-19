using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebGame.Content.ItemGeneration
{
    public abstract class EquippableItem : Item
    {
        #region Properties
        public string BaseType { get; set; }
        public Prefix Prefix { get; set; }
        public Prefix SecondaryPrefix { get; set; }
        public Suffix Suffix { get; set; }
        public int ItemLevel { get; set; }
        public AffixBonuses AffixBonuses { get; set; }
        public List<PassiveEffects> PassiveEffects { get; set; }
        #endregion

        #region Overrides
        public override void EquipItem()
        {
            throw new NotImplementedException();
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
            throw new InvalidOperationException();
        }
        #endregion
    }
}
