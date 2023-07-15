using ConsoleApplication1.Asset.Mathf;
using CoreContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Asset.Components._Transform {
    internal interface ITransform : IAsset {
        Vector3 position { get; set; }

        Vector3 rotation { get; set; }

        Vector3 scale { get; set; }

        GameObject gameObject { get; }
    }
}
