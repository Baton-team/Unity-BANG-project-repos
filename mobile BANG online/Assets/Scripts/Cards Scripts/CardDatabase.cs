using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class CardDatabase : MonoBehaviour
    {
        public static List<Card> cardList = new List<Card>();

        void Awake()
        {
            cardList.Add(new Bang(1));
            cardList.Add(new Carabin(2));
            cardList.Add(new Beer(3));
            cardList.Add(new Gatling(4));
        }
    }
}
