using System;

namespace CoreContext.material
{
    public class OakDoorMaterialAsset : BaseMaterialAsset
    {
        public OakDoorMaterialAsset(string source) : base(source)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Oak Door Material");
        }
    }
}