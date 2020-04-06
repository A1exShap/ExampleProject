using System.Collections.Generic;


namespace ExampleTemplate
{
    public sealed class ItemCleanUp : ICleanUp
    {      
        #region Fields
                   
        private readonly List<ItemBehaviour> _itemBehaviours;
                   
        #endregion
           
                   
        #region ClassLifeCycles
           
        public ItemCleanUp()
        {
            _itemBehaviours = ItemExtensions.Items;
        }
                   
        #endregion
        
        
        #region ICleanUp

        public void Cleaner()
        {
            _itemBehaviours.Clear();
        }

        #endregion
    }
}
