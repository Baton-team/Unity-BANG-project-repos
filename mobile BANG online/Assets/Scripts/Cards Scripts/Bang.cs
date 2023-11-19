using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Bang : Card
    {
        // Start is called before the first frame update
        
        public Bang(string name) : base(name) {}

        public override void Ability(IPlayer target)
        {
            if (IsPlayable)
            {
                target.React();
            }
        }
        // Update is called once per frame
        
    }
}