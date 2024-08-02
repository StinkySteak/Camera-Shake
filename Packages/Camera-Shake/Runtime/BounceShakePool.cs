using System.Collections.Generic;
using UnityEngine;

namespace CameraShake
{
    public class BounceShakePool
    {
        private const int POOL_SIZE = 32;

        private BounceShake[] _bounceShakes;
        private BounceShake.Params[] _params;

        private int _indexerShake;
        private int _indexerParams;

        public BounceShake GetShake()
        {
            if (_indexerShake >= POOL_SIZE)
                _indexerShake = 0;

            return _bounceShakes[_indexerShake++];
        }

        public BounceShake.Params GetParams()
        {
            if (_indexerParams >= POOL_SIZE)
                _indexerParams = 0;

            return _params[_indexerParams++];
        }

        public void InitPool()
        {
            _bounceShakes = new BounceShake[POOL_SIZE];
            _params = new BounceShake.Params[POOL_SIZE];

            for (int i = 0; i < POOL_SIZE; i++)
            {
                _params[i] = new BounceShake.Params();
                _bounceShakes[i] = new BounceShake();
            }
        }
    }
}