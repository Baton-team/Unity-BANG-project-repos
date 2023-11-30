using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Bang : Card
    {
        string Name = "Bang";
        string cardDiscription = "BANG card";

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