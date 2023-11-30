using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Deck : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }
        public List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            for (int i = 0; i < 25; i++)
            {
                Bang bang = new Bang();
                cards.Add(bang);
            }
        }

        private void Shuffle()
        {
            System.Random rng = new System.Random();
            cards.Sort((a, b) => rng.Next(-1, 2));
        }

        public Card GiveCard()
        {
            Card FirstCard = cards[0];
            cards.RemoveAt(0);
            if (cards.Count == 0)
            {
                cards = new List<Card>();
            }
            return FirstCard;
        }
        // Update is called once per frame
        void Update()
        {
            
        }
    }
}