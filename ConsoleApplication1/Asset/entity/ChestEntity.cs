using System;
using System.Collections.Generic;
using CoreContext.material;
using CoreContext.texture;

namespace CoreContext
{
    public class ChestEntity : BaseEntityAsset
    {
        
        

        public void contains(List<BaseEntityAsset> items)
        {
            
        }
        
        public List<BaseEntityAsset> getFromChest()
        {
            return null;
        }

        public ChestEntity(BaseMaterialAsset materialAsset, BaseTextureAsset baseTextureAsset) : base(materialAsset, baseTextureAsset)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Chest Entity");
        }
    }
}