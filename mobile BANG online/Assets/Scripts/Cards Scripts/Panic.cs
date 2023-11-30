using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Panic : Card
    {
        public int id;
        public string Name = "Panic";
        public string cardDiscription = "Panic card";

        public bool IsPlayable;
        
        public Panic(string name) : base(name) {}
        public Panic(int Id) : base(Id) {}

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