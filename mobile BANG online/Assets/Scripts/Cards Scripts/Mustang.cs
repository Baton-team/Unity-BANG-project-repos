using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Mustang : Card
    {
        public int id;
        public string Name = "Mustang";
        public string cardDiscription = "Mustang card";

        public bool IsPlayable;
        
        public Mustang(string name) : base(name) {}
        public Mustang(int Id) : base(Id) {}

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