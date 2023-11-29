using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Indians : Card
    {
        public int id;
        public string Name = "Indians";
        public string cardDiscription = "Indians card";

        public bool IsPlayable;
        
        public Indians(string name) : base(name) {}
        public Indians(int Id) : base(Id) {}

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