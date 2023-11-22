using Com.BATONteam.mobileBANGonline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuzyLafayette : IPlayer
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "SuzyLafayette";
        Hp = 4;
        if (Role.Name == "Sheriff")
        {
            ++Hp;
        }
        Weapon = new Weapon("Kolt", 1);
        DisanceTo = Weapon.Distance;
        IsDead = false;
    }

    public new void PlayCards(Deck deck)
    {
        if (Hand.Count == 0)
        {
            TakeCard(deck);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
