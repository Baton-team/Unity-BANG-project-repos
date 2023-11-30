using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Volcanic : Weapon
    {
        public int id;
        public string Name = "Volcanic";
        public string cardDiscription = "Volcanic card";

        public bool IsPlayable;
        
        public Volcanic(string name) : base(name) {}
        public Volcanic(int Id) : base(Id) {}

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