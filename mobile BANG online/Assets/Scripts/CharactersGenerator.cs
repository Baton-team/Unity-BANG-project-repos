using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] characterslist;

    public void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            int rand = Random.Range(0, characterslist.Length);
            GameObject temp = Instantiate(characterslist[rand], new Vector2(0+i, 0+i), Quaternion.identity) as GameObject;
        }
    }

    // Update is called once per frame
    private void Update()
    {

    }
}
