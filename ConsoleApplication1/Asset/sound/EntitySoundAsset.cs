using System;

namespace CoreContext
{
    public class EntitySoundAsset : BaseSoundAsset
    {
        public EntitySoundAsset(string source) : base(source)
        {
            
        }

        public void doSomething()
        {
            
        }

        public override void Show()
        {
            Console.WriteLine("Entity Sound Asset");
        }
    }
}