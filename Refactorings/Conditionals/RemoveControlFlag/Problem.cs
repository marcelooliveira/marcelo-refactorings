using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.Conditionals.RemoveControlFlag
{
    class Problema
    {
        public Problema()
        {
            Bird bird = new European();

            // Somewhere in client code
            var speed = bird.GetSpeed();
        }
    }

    public abstract class Bird
    {
        //...
        public abstract double GetSpeed();
    }

    class European : Bird
    {
        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }

        private double GetBaseSpeed()
        {
            throw new NotImplementedException();
        }
    }
    class African : Bird
    {
        private int numberOfCoconuts;

        public override double GetSpeed()
        {
            return GetBaseSpeed() - GetLoadFactor() * numberOfCoconuts;
        }

        private int GetLoadFactor()
        {
            throw new NotImplementedException();
        }

        private int GetBaseSpeed()
        {
            throw new NotImplementedException();
        }
    }
    class NorwegianBlue : Bird
    {
        private bool isNailed;
        private object voltage;

        public override double GetSpeed()
        {
            return isNailed ? 0 : GetBaseSpeed(voltage);
        }

        private int GetBaseSpeed(object voltage)
        {
            throw new NotImplementedException();
        }
    }

}
