using UnityEngine;

public class Jango : IPlayer
{
    public Jango(Role role, string name, int hp, Deck deck)
        : base(role, name, hp, deck)
    {

    }
}