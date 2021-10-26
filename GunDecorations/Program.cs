using System;

namespace GunDecorations
{
    class Program
    {
        static void Main(string[] args)
        {
           Gun machineGun = new MachineGun();
           Gun shotGun = new Shotgun();

           shotGun = new GunClip(shotGun);
           shotGun = new GunSilencer(shotGun);
           
           machineGun.fire();
           shotGun.fire();

        }
    }
}
