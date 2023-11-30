using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Carabin : Weapon
    {
        public int id;
        public string Name = "Carabin";
        public string cardDiscription = "Carabin card";

        public bool IsPlayable;
        
        public Carabin(string name) : base(name) {}
        public Carabin(int Id) : base(Id) {}
        
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