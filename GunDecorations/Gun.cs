using System;

namespace GunDecorations
{
    public abstract class Gun
    {
        public virtual int AmmoCapacity {get;}
        public virtual float NoiseLevel {get;}



        public void fire()
        {
            Console.Write($"This is your ammo : {AmmoCapacity}");
            Console.WriteLine($"This is the noise level : {NoiseLevel}");
        }
    }
}