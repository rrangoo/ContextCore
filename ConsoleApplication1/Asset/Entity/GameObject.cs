using CoreContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Asset.Components._Transform;

namespace ConsoleApplication1.Asset {
    public class GameObject : IAsset {
        private List<IAsset> listComponents = new List<IAsset>();

        public GameObject() {
            listComponents.Add(new Transform(this));
        }

        public IAsset GetComponent(IAsset asset) {
            if (!listComponents.Contains(asset)) 
                return null;

            IAsset result = null;
            for (int i = 0; i < listComponents.Count; i++) {
                if (listComponents[i] != asset)
                    continue;

                result = listComponents[i];
                break;
            }
            return result;
        }
    }
}
