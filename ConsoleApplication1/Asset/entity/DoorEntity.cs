using ConsoleApplication1.util;
using CoreContext.material;
using CoreContext.texture;

namespace CoreContext
{
    public class DoorEntity : BaseEntityAsset
    {
        private EntitySoundAsset _open;
        private EntitySoundAsset _close;


        public BaseSoundAsset SoundAsset;

        public DoorEntity(BaseMaterialAsset materialAsset, BaseTextureAsset baseTextureAsset) : base(materialAsset, baseTextureAsset)
        {
        }

        public void open()
        {
            SoundPlayer.play(_open);
            // do logic
        }
        
        public void close()
        {
            SoundPlayer.play(_close);
        }
    }
}