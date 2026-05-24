using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Combat_Simulator
{
    public interface IDamageable
    {
        public void TakeDamage(float attackPower);
    }
}
