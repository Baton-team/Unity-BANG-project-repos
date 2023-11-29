using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Scope : Card
    {
        public int id;
        public string Name = "Scope";
        public string cardDiscription = "Scope card";

        public bool IsPlayable;
        
        public Scope(string name) : base(name) {}
        public Scope(int Id) : base(Id) {}

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