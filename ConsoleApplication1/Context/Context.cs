using System.Collections.Generic;
using CoreContext.assets;

namespace CoreContext
{
    public class Context
    {
        public Dictionary<string, BaseAssetContainer> AssetContainers { get; private set; }

        public void Init()
        {
            AssetContainers = new Dictionary<string, BaseAssetContainer>();
        }

        public void Add(string tag, IAsset asset)
        {
            if (!AssetContainers.ContainsKey(tag))
            {
                AssetContainers[tag] = new BaseAssetContainer();
                AssetContainers[tag].values = new List<IAsset>();
            }
            AssetContainers[tag].values.Add(asset);
        }
    }
}