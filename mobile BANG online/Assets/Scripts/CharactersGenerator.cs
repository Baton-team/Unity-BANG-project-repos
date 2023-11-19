using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] characterslist;
    public GameObject[] characters;
    public void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            int rand = Random.Range(0, characterslist.Length - 1);
            GameObject temp = Instantiate(characterslist[rand], new Vector2(0, 0), Quaternion.identity) as GameObject;
            characters[i] = temp;
        }
    }

    // Update is called once per frame
    private void Update()
    {

    }
}
