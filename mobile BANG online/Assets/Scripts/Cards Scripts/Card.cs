using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Card : MonoBehaviour
    {
        protected int Id;
        protected string Name;
        public string cardDiscription;
        
        protected bool IsPlayable;

        public Card(){}
        public Card(string name)
        {
            Name = name;
            IsPlayable = true;
        }
        public Card(int id)
        {
            Id = id;
        }
        public void CopyFrom(Card another)
        {
            Name = another.Name;
            IsPlayable = another.IsPlayable;
        }
        public virtual void Ability(IPlayer another)
        {
            if (another == null) { }
        }

        void Start()
        {

        }

        void Update()
        {

        }
    }
}
