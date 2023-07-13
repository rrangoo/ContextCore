using System;
using ConsoleApplication1.util;
using CoreContext.material;
using CoreContext.texture;

namespace CoreContext
{
    public class DoorEntity : BaseEntityAsset
    {
        private EntitySoundAsset openSoundAsset;
        private EntitySoundAsset closeSoundAsset;

        public EntitySoundAsset OpenSoundAsset
        {
            get => openSoundAsset;
            set => openSoundAsset = value;
        }

        public EntitySoundAsset CloseSoundAsset
        {
            get => closeSoundAsset;
            set => closeSoundAsset = value;
        }

        public void open()
        {
            SoundPlayer.play(openSoundAsset);
            // do logic
        }
        
        public void close()
        {
            SoundPlayer.play(closeSoundAsset);
        }

        public DoorEntity(BaseMaterialAsset materialAsset, BaseTextureAsset baseTextureAsset) : base(materialAsset, baseTextureAsset)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Door Enity");
        }
    }
}