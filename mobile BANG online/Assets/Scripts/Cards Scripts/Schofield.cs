using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Schofield : Weapon
    {
        public int id;
        public string Name = "Schofield";
        public string cardDiscription = "Schofield card";

        public bool IsPlayable;
        
        public Schofield(string name) : base(name) {}
        public Schofield(int Id) : base(Id) {}

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