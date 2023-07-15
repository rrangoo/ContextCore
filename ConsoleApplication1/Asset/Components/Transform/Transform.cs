using ConsoleApplication1.Asset.Mathf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Asset.Components._Transform {
    public class Transform : ITransform {
        private Vector3 _position = new Vector3 (0, 0, 0);
        private Vector3 _rotation = new Vector3 (0, 0, 0);
        private Vector3 _scale = new Vector3 (0, 0, 0);
        private GameObject _gameObject;

        public Vector3 position {
            get => _position;
            set =>  _position = value;
        }

        public Vector3 rotation {
            get => _rotation;
            set => _rotation = value;
        }

        public Vector3 scale {
            get => _scale;
            set => _scale = value;
        }

        public GameObject gameObject => _gameObject;

        public Transform (GameObject gameObject) {
            if (gameObject == null) {
                _gameObject = gameObject;
            }
            _position = new Vector3(0, 0, 0);
            _rotation = new Vector3(0, 0, 0);
            _scale = new Vector3(0, 0, 0);

        }
    }
}
