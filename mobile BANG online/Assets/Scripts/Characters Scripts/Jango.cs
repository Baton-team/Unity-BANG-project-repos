using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Jango : IPlayer
{
        private void Start()
        {
            Name = "Jango";
            Hp = 3;
            if (Role.Name == "Sheriff")
            {
                ++Hp;
            }
            Weapon = new Weapon("Schofield", 1);
            DisanceTo = Weapon.Distance;
            IsDead = false;
        }

        public override void TakeDamage(IPlayer another)
        {
            base.TakeDamage(another);
            int rand = Random.Range(0, another.Hand.Count);
            Card temp = another.Hand[rand];
            another.Hand.RemoveAt(rand);
        }
        //private Role Role;
        //private string Name;
        //private string ID;
        //private int Hp;
        //private List<Card> Hand;
        //private Weapon Weapon;
        //private int DisanceTo;
        //private int DistanceFrom;//?
        //private bool IsDead = false;


    }
}