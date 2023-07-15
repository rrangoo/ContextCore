using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Asset.Mathf {
    public class Vector3 {
        private float _x;
        private float _y;
        private float _z;

        public float x => _x;
        public float y => _y;
        public float z => _z;

        public Vector3(float x, float y, float z) {
            _x = x;
            _y = y;
            _z = z;
        }
    }
}