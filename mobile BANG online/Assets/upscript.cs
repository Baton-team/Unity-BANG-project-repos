using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickCardItUps()
    {
        Debug.Log("Clicked on card");
        Vector3 objectPosition = transform.position;

        // Підніміть об'єкт на 5 одиниць по осі y.
        objectPosition.y += 1f;

        // Встановіть нову позицію об'єкта.
        transform.position = objectPosition;
    }
}
