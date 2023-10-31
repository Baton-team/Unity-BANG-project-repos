using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bang : Card
{
    // Start is called before the first frame update
    
    public Bang(string name) : base(name) {}

    public override void Ability(IPlayer target)
    {
        if (IsPlayable)
        {
            target.TakeDamage();
        }
    }
    // Update is called once per frame
    
}
