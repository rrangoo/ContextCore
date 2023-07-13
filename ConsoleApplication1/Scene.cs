using System;
using CoreContext;
using CoreContext.material;
using CoreContext.texture;

namespace ConsoleApplication1
{
    public class Scene
    {            
        Context context;

        public void Init()
        { 
            context = new Context();
            context.Init();
        }
        
        public void Load()
        {
            BaseTextureAsset textureAsset = new LookingGoodDoorTextureAsset("");
            context.Add("SceneTexture", textureAsset);
            
            BaseMaterialAsset materialAsset = new OakDoorMaterialAsset("");
            context.Add("SceneMaterial", materialAsset);
            BaseSoundAsset openSoundAsset = new DoorOpenSoundAsset("");
            context.Add("SceneSound", openSoundAsset);


            DoorEntity doorEntity = new DoorEntity(materialAsset, textureAsset);
            context.Add("SceneEntity", doorEntity);


            BaseSoundAsset closeSoundAsset = new DoorOpenSoundAsset("");
            context.Add("SceneSound", closeSoundAsset);
        }

        public void Show()
        {
            foreach (var c in context.AssetContainers)
            {
                Console.WriteLine(c.Key);
                foreach (var asset in c.Value.values)
                {
                    Console.WriteLine(asset);
                }
            }
        }
    }
}