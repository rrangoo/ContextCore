using ConsoleApplication1.util;
using CoreContext.material;
using CoreContext.texture;

namespace CoreContext
{
    public class DoorEntity : BaseEntityAsset
    {
        private EntitySoundAsset open;
        private EntitySoundAsset close;
        
        public void open()
        {
            SoundPlayer.play(open);
            // do logic
        }
        
        public void close()
        {
            SoundPlayer.play(close);
        }
    }
}