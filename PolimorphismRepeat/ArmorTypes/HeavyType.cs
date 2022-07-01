using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismRepeat
{
    public class HeavyType : IType
    {
        public string TypeName { get => "Heavy armor"; }
        public int SpeedBonus { get { return -6; } }
        public int HPBonus { get { return 40; } }
        public int Weigth { get { return 6; } }
    }
}
