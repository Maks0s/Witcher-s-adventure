using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismRepeat
{
    public class HeavyType : IType
    {
        public int SpeedBonus { get => -16; }
        public int HPBonus { get => +40; }
        public int Weigth { get => +16; }
    }
}
