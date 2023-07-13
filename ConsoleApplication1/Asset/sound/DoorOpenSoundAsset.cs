using System;

namespace CoreContext
{
    public class DoorOpenSoundAsset : EntitySoundAsset
    {
        public DoorOpenSoundAsset(string source) : base(source)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Door Open Sound Asset");
        }
    }
}