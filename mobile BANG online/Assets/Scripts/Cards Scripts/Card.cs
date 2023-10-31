using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Card : MonoBehaviour
    {
        void Start()
        {

        }
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

        void Update()
        {

        }
    }
}
