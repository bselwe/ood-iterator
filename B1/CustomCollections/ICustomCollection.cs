using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.CustomCollections
{
    public interface ICustomCollection<T>
    {
        int Size { get; }
        T Get(int n);
    }
}
