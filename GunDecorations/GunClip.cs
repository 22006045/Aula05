using System;
namespace GunDecorations
{
    public  class GunClip : GunDecorator
    {
        public override int AmmoCapacity => (int)(base.AmmoCapacity * 1.5);

         public GunClip(Gun decoratedGun) : base(decoratedGun)
         {

         }

    }
}