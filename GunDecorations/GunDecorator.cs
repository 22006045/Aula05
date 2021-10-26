using System;

namespace GunDecorations
{
    public abstract class GunDecorator : Gun
    {
        public override int AmmoCapacity => decoratedGun.AmmoCapacity;
        public override float NoiseLevel => decoratedGun.NoiseLevel;
        private readonly Gun decoratedGun;


        public GunDecorator (Gun decoratedGun)
        {
            this.decoratedGun = decoratedGun;
        }
    }
}