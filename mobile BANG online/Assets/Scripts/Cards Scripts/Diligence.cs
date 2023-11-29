using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Com.BATONteam.mobileBANGonline
{
    public class Diligence : Card
    {
        public int id;
        public string Name = "Diligence";
        public string cardDiscription = "Diligence card";

        public bool IsPlayable;
        
        public Diligence(string name) : base(name) {}
        public Diligence(int Id) : base(Id) {}
        
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