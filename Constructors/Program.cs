using System;
using System.Diagnostics;

namespace Constructors
{
    class Vehicle
    {
        protected double _lenght;
        protected double _weight;
        protected double _topspeed;

        public void SetLenght(double nr)
        {
            this._lenght = nr;
        }

        public void SetWeight(double nr2)
        {
            this._weight = nr2;
        }

        public void SetTopSpeed(double nr3)
        {
            this._topspeed = nr3;
        }

        public double GetLenght()
        {
            return this._lenght;
        }

        public double GetWeight()
        {
            return this._weight;
        }

        public double GetTopspeed()
        {
            return this._topspeed;
        }
    }

    class Boat: Vehicle
    {
        private int _windResistance;
        private int _windSpeed;
        public bool Usable;

        public Boat()
        {
            if (_windResistance > _windSpeed)
                Usable = true;
        }
    }

    class Airplane: Vehicle
    {
        private double dragCoefficient = 24;

        public void SetDragCoefficient(double nr4)
        {
            if (this.dragCoefficient > 0 && this.dragCoefficient < 25)
                Console.WriteLine("The airplane is unsafe to fly");
            else
                Console.WriteLine("The airplane is perfectly safe to fly");
        }

        public double GetDragCoefficient()
        {
            return this.dragCoefficient;
        }
    }
}
