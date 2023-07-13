using System;
using System.Collections;
using System.Collections.Generic;
using CoreContext.material;
using CoreContext.texture;

namespace CoreContext
{
    public abstract class BaseEntityAsset : IAsset
    {
        private Dictionary<string, BaseMaterialAsset> _materialAssets;
        private Dictionary<string, BaseTextureAsset> _textureAssets;

        protected BaseEntityAsset(BaseMaterialAsset materialAsset, BaseTextureAsset baseTextureAsset)
        {
            
        }

        public abstract void Show();
    }
}