using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Missed : Card
    {
        public int id;
        public string Name = "Missed";
        public string cardDiscription = "Missed card";

        public bool IsPlayable;
        
        public Missed(string name) : base(name) {}
        public Missed(int Id) : base(Id) {}

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}