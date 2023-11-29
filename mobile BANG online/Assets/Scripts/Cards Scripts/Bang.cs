using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Bang : Card
    {
        public int id;
        public string Name = "Bang";
        public string cardDiscription = "BANG card";

        public bool IsPlayable;
        
        public Bang(string name) : base(name) {}
        public Bang(int Id) : base(Id) {}

        public override void Ability(IPlayer target)
        {
            if (IsPlayable)
            {
                target.TakeDamage();
            }
        }
        // Update is called once per frame
        
    }
}