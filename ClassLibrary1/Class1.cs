using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheGeneral
{
    

    public interface IOperationSuccessCalculator
    {
        bool IsAttackSuccesful(int x, int y);
        bool IsDefenceSuccesful(int x, int y);
    }

    public class General : IOperationSuccessCalculator
    {

        public bool IsAttackSuccesful(int x, int y)
        {
            if (x > 200 || y > 300)
            {
                throw new System.Exception("Parameters exceed board dimensions!");
            }

            else if ((x + y - 5) % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsDefenceSuccesful(int x, int y)
        {
            if (x > 200 || y > 300)
            {
                throw new System.Exception("Parameters exceed board dimensions!");
            }

            else if ((x * y - 5) % 2 == 0)
            {
                return true;
            }


            else
            {
                return false;
            }
        }
    }


}
