using ConsoleApplication1.Asset;
using ConsoleApplication1.Asset.Components._Transform;

namespace ConsoleApplication1.Asset.Components._Texture {
    public abstract class BaseTextureAsset : ITexture {
        private string _source;

        private Transform _transform;
        private GameObject _gameObject;

        public GameObject gameObject => _gameObject;
        public Transform transform => _transform;


        public BaseTextureAsset(Transform transform, string source) {
            if (transform.gameObject == null)
                return;

            _transform = transform;
            _gameObject = transform.gameObject;
            _source = source;
        }
    }
}