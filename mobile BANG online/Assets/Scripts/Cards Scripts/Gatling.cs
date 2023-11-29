using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Gatling : Card
    {
        public int id;
        public string Name = "Gatling";
        public string cardDiscription = "Gatling card";

        public bool IsPlayable;
        
        public Gatling(string name) : base(name) {}
        public Gatling(int Id) : base(Id) {}

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