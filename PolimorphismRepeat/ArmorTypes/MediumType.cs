using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismRepeat
{
    internal class MediumType : IType
    {
        public int SpeedBonus { get => -4; }
        public int HPBonus { get => +20; }
        public int Weigth { get => +4; }
    }
}
