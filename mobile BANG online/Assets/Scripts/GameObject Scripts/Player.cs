using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace Com.BATONteam.mobileBANGonline
{
    public abstract class Player : MonoBehaviour
    {
        // Start is called before the first frame update

        private Role Role;
        private string Name;
        private string ID;
        private int Hp;
        private List<Card> Hand;
        private Weapon Weapon;
        private int DisanceTo;
        private int DistanceFrom;//?
        private bool IsDead = false;

        void Start()
        {
            
        }

        public void TakeCard(Deck deck)
        {
            if (deck.cards.Count > 0)
            {
                Hand.Add(deck.cards[0]);
                deck.GiveCard();
            }
        }

        public void TakeDamage()
        {
            Hp -= 1;
            if (Hp <= 0)
            {
                IsDead = true;
            }
        }

        public void PlayCards()
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