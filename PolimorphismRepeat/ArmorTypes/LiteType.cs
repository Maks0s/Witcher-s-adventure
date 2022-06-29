using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismRepeat
{
    internal class LiteType : IType
    {
        public int SpeedBonus { get => 0; }
        public int HPBonus { get => +10; }
        public int Weigth { get => 0; }
    }
}
