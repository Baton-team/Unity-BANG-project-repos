using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Com.BATONteam.mobileBANGonline;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
     public class Deck : MonoBehaviour
 {
     Vector2 vector = new(){ x = 700 , y = 230 };
     public List<GameObject> cards;
     public  List<GameObject> instances;
     private void InstansCard(List<GameObject> cards, int num, int count){
        for(int i=0; i <num; i++){
            GameObject temp;
            temp = Instantiate(instances[count],vector, Quaternion.identity);
            cards.Add(temp);
        }
    }
     void Start()
     {
        int [] NumOfCardInstances = new int[]{25, 6, 2, 1, 2, 4, 12, 2, 4, 1, 1, 3, 1, 2, 1};

        for(int i = 0; i<instances.Count(); i++){
                InstansCard(cards,NumOfCardInstances[i],i);
           
        }
     }
     private void Shuffle()
     {
         System.Random rng = new System.Random();
         cards.Sort();
     }

     public GameObject GiveCard()
     {
         GameObject FirstCard = cards[0];
         cards.RemoveAt(0);
         if (cards.Count == 0)
         {
                List<GameObject> gameObjects = new();
                cards = gameObjects;
         }
         return FirstCard;
     }
     // Update is called once per frame
     void Update()
     {
         
     }
 }
}

//  for(int i = 0; i < 25; i++)
        //  {
        //     GameObject temp;
        //     int j;

        //      if (i < 25)
        //      {
        //          j = 0;
        //      }else j = 1;
        //      temp = Instantiate(instances[j], new Vector2(0, 0), Quaternion.identity);
        //      cards.Add(temp);

        //  }