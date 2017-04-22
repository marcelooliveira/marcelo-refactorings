using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.ReplaceConditionalwithPolymorphism
{
    class Problema
    {
    }

    public class Bird
    {
        private int type;
        private int numberOfCoconuts;
        private object voltage;
        private bool isNailed;

        const int EUROPEAN = 1;
        const int AFRICAN = 2;
        const int NORWEGIAN_BLUE = 3;

        //...
        public double GetSpeed()
        {
            switch (type)
            {
                case EUROPEAN:
                    return GetBaseSpeed();
                case AFRICAN:
                    return GetBaseSpeed() - GetLoadFactor() * numberOfCoconuts;
                case NORWEGIAN_BLUE:
                    return isNailed ? 0 : GetBaseSpeed(voltage);
                default:
                    throw new Exception("Should be unreachable");
            }
        }

        private int GetBaseSpeed(object voltage)
        {
            throw new NotImplementedException();
        }

        private int GetLoadFactor()
        {
            throw new NotImplementedException();
        }

        private double GetBaseSpeed()
        {
            throw new NotImplementedException();
        }
    }
}
