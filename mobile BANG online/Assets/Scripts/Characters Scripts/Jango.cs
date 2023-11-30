using UnityEngine;
using System;

namespace Com.BATONteam.mobileBANGonline
{
    public class Jango : IPlayer
{

        void Start()
        {
            Name = "Jango";
            Hp = 3;
            //if (Role.Name == "Sheriff")
            //{
            //    ++Hp;
            //}
            Weapon = new Weapon("Kolt", 1);
            DisanceTo = Weapon.Distance;
            IsDead = false;
        }

        public new void TakeDamage(IPlayer another)
        {
            base.TakeDamage();
            int num = UnityEngine.Random.Range(0, another.Hand.Count);
            GameObject temp = another.Hand[num];
            another.Hand.RemoveAt(num);
        }

        
    }
}