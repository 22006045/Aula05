using System;
namespace GunDecorations
{
    public class Shotgun : Gun
    {
        public override int AmmoCapacity => 8;
        public override float NoiseLevel => 200.0f;
    }
}