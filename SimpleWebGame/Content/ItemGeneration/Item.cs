using SimpleWebGame.Content.Interfaces;
using System;
using System.Collections.Generic;

namespace SimpleWebGame.Content.ItemGeneration
{
    public abstract class Item : IItemActions, ILogger
    {
        #region Properties
        public Guid guid { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public List<ItemRequirements> Requriements { get; set; }
        #endregion

        #region Interface inherited methods
        public abstract void EquipItem();
        public abstract void Log();
        public abstract void RemoveItem();
        public abstract void SellItem();
        public abstract void UseItem();
        #endregion

        #region Abstract methods
        public abstract void GenerateNewItem(int itemType);
        #endregion
    }
}