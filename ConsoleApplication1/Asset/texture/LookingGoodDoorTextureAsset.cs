using System;

namespace CoreContext.texture
{
    public class LookingGoodDoorTextureAsset : BaseTextureAsset
    {
        public LookingGoodDoorTextureAsset(string source) : base(source)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Looking Good Door Texture Asset");
        }
    }
}