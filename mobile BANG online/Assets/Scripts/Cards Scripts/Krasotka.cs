using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Krasotka : Card
    {
        public int id;
        public string Name = "Krasotka";
        public string cardDiscription = "Krasotka card";

        public bool IsPlayable;
        
        public Krasotka(string name) : base(name) {}
        public Krasotka(int Id) : base(Id) {}

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