using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebGame.Content.ItemGeneration
{
    public class Weapon : EquippableItem
    {
        #region Properties
        public int MinumumDamage { get; set; }
        public int MaximumDamage { get; set; }        
        #endregion

        public override void GenerateNewItem(int itemType)
        {
            throw new NotImplementedException();
        }        
    }
}