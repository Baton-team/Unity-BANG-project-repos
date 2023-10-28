using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Card
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int Distance;

    public Weapon(string name, int value) : base(name)
    {
        Distance = value;
    }

    public override void Ability(IPlayer ThisPlayer)
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}