using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Card : MonoBehaviour
    {
        protected int id;
        protected string Name;
        public string cardDiscription;
        
        protected bool IsPlayable;

        public Card(){}
        public Card(string name)
        {
            Name = name;
            IsPlayable = true;
        }
        public Card(int Id)
        {
            id = Id;
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

        void Start()
        {

        }

        void Update()
        {

        }
    }
}
