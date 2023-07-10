namespace CoreContext.texture
{
    public abstract class BaseTextureAsset : IAsset
    {
        private string source;

        public BaseTextureAsset(string source)
        {
            this.source = source;
        }
    }

    
}