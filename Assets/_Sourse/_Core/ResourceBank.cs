using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace _Core
{
    public class ResourceBank
    {
        private Dictionary<GemeResource, ObservableInt> _data = new Dictionary<GemeResource, ObservableInt>();

        public void ChangeResource(GemeResource r, int v)
        {
            if (_data.ContainsKey(r))
            {
                _data[r].Value += v;
                Debug.Log($"Resourse {r} updated on: {v}");
            }
            else
            {
                _data.Add(r, new ObservableInt(v));
                Debug.Log($"Resourse {r} added: {v}");
            }
        }

        public int GetResource(GemeResource r)
        {
            if (_data.ContainsKey(r))
            {
                return _data[r].Value;
            }
            else
            {
                return 0;
            }
        }
    }
}