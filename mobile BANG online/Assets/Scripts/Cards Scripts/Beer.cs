using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public class Beer : Card
    {
        public int id;
        public string Name = "Beer";
        public string cardDiscription = "Beer card";

        public bool IsPlayable;
        
        public Beer(string name) : base(name) {}
        public Beer(int Id) : base(Id) {}
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