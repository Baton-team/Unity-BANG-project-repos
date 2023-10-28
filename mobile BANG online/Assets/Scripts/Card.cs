using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
    protected string Name;

    protected bool IsPlayable;

    public Card(string name)
    {
        Name = name;
        IsPlayable = true;
    }
    public void CopyFrom(Card another)
    {
        this.Name = another.Name;
        this.IsPlayable = another.IsPlayable;
    }
    public virtual void Ability(IPlayer another)
    {
        if (another == null) { }
    }
}
