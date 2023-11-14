using System.Collections.Generic;
using System.Collections.ObjectModel;
using _Source._Core;

namespace _Source._Core
{
    public class ResourceBank
    {
        private Dictionary<GameResource, ObservableInt> _resourceDict = new();

        public void ChangeResource(GameResource r, int v)
        {
            if (_resourceDict.ContainsKey(r))
            {
                _resourceDict[r].Value += v;
            }
            else
            {
                _resourceDict.Add(r, new ObservableInt(v));
            }
        }

        public ObservableInt GetResource(GameResource r)
        {
            return _resourceDict[r];
        }
    }
}