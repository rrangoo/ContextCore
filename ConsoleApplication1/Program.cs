using CoreContext;
using CoreContext.material;
using CoreContext.texture;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            // create
            BaseTextureAsset textureAsset = new LookingGoodDoorTextureAsset("");
            BaseMaterialAsset materialAsset = new OakDoorMaterialAsset("");
            BaseSoundAsset openSoundAsset = new DoorOpenSoundAsset("");
            
            DoorEntity doorEntity = new DoorEntity(materialAsset, textureAsset);
            
            doorEntity.open();
            
            BaseSoundAsset closeSoundAsset = new DoorOpenSoundAsset("");
            doorEntity.SoundAsset = closeSoundAsset;
            doorEntity.close();
            
            // Load to context
            
            // Get from context and print in console
        }
    }
}