using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public abstract class IPlayer : MonoBehaviour
    {
        // Start is called before the first frame update

        protected Role Role;
        protected string Name;
        protected string ID;
        protected int Hp;
        public List<Card> Hand;
        protected Weapon Weapon;
        protected int DisanceTo;
        protected int DistanceFrom;//?
        protected bool IsDead;

        //void Start()
        //{
            
        //}

        public void TakeCard(Deck deck)
        {
            if (deck.cards.Count > 0)
            {
                Hand.Add(deck.GiveCard());
                
            }
        }

        public virtual void TakeDamage()
        {

            Hp -= 1;
            if (Hp <= 0)
            {
                IsDead = true;
            }
        }

        public virtual void PlayCards()
        {

        }

        public void React()
        {

        }

        /*
        public IPlayer(Role role, string name, int hp, Deck deck)
        {
            Role = role;
            Name = name;
            Hp = hp;
            Weapon = new Weapon("Scofield", 1);
            DisanceTo = Weapon.Distance;
            IsDead = false;
            for (int i = 0; i < hp; i++)
            {
                TakeCard(deck);
            }
        }
        // Update is called once per frame
        */
    }

}