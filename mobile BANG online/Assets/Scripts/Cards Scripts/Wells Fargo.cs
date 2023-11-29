using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class WellsFargo : Card
    {
        public int id;
        public string Name = "WellsFargo";
        public string cardDiscription = "WellsFargo card";

        public bool IsPlayable;
        
        public WellsFargo(string name) : base(name) {}
        public WellsFargo(int Id) : base(Id) {}

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