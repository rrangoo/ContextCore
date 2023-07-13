namespace CoreContext.material
{
    public abstract class BaseMaterialAsset : IAsset
    {
        private string source;

        public BaseMaterialAsset(string source)
        {
            this.source = source;
        }

        public abstract void Show();
    }
}