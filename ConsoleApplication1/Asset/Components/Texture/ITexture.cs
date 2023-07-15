using CoreContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Asset.Components._Transform;

namespace ConsoleApplication1.Asset.Components._Texture {
    internal interface ITexture : IAsset {
        GameObject gameObject { get; }
        Transform transform { get; }
    }
}
