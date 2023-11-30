using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Salun : Card
    {
        public int id;
        public string Name = "Salun";
        public string cardDiscription = "Salun card";

        public bool IsPlayable;
        
        public Salun(string name) : base(name) {}
        public Salun(int Id) : base(Id) {}

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