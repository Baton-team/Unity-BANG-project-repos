using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Remington : Weapon
    {
        public int id;
        public string Name = "Remington";
        public string cardDiscription = "Remington card";

        public bool IsPlayable;
        
        public Remington(string name) : base(name) {}
        public Remington(int Id) : base(Id) {}

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