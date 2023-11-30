using Com.BATONteam.mobileBANGonline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButchCassidy: IPlayer
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Butch Cassidy";
        Hp = 4;
        //if (Role.Name == "Sheriff")
        //{
        //    ++Hp;
        //}
        Weapon = new Weapon("Kolt", 1);
        DisanceTo = Weapon.Distance;
        IsDead = false;
    }

    public new void TakeDamage(IPlayer another, Deck deck)
    {
        base.TakeDamage();
        TakeCard(deck);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
