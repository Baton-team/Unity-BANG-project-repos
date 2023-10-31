using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : MonoBehaviour
{
    public string Name { get; }

    public Role(string name)
    {
        try
        {
            switch (name)
            {
                case "Sheriff":
                    Name = "Sheriff";
                    break;
                case "Bandit":
                    Name = "Bandit";
                    break;
                case "Assistant":
                    Name = "Assistant";
                    break;
                case "Renegade":
                    Name = "Renegade";
                    break;
                default:
                    throw new ArgumentException("The name is not suitable.");
            }
        }
        catch (ArgumentException)
        {
            //the name is not suitable
            Console.WriteLine("The name is not suitable.");
        }
    }
}
