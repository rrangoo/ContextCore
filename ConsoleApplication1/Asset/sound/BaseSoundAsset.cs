namespace CoreContext
{
    public abstract class BaseSoundAsset : IAsset
    {
        private string source;

        public BaseSoundAsset(string source)
        {
            this.source = source;
        }

        public abstract void Show();
    }
}