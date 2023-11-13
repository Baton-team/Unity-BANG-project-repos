using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public abstract class IPlayer : MonoBehaviour
    {
        // Start is called before the first frame update

        Role Role;
        string Name;
        string ID;
        int Hp;
        List<Card> Hand;
        Weapon Weapon;
        int DisanceTo;
        int DistanceFrom;//?
        bool IsDead = false;

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
    }

}