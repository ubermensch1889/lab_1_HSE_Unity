using System.Collections.Generic;
using System.Collections.ObjectModel;
using _Source._Core;

namespace _Source._Core
{
    public class ResourceBank
    {
        private Dictionary<GameResource, ObservableInt> _resourceDict;

        public void ChangeResource(GameResource r, int v)
        {
            _resourceDict[r] = new ObservableInt(_resourceDict[r].Value + v);
        }

        public ObservableInt GetResource(GameResource r)
        {
            return _resourceDict[r];
        }
    }
}