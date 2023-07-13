using System;

namespace CoreContext
{
    public class LevelSoundAsset : BaseSoundAsset
    {
        public LevelSoundAsset(string source) : base(source)
        {
        }
        
        public void doAnotherSomething()
        {
            
        }

        public override void Show()
        { 
            Console.WriteLine("Level Sound Asset");
        }
    }
}