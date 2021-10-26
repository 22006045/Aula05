using System;

namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {

        public override float NoiseLevel => (float)(base.NoiseLevel * 0.2f);
        public GunSilencer (Gun decoratedGun) : base(decoratedGun)
        {

        }

        
    }
}