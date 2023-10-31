using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.BATONteam.mobileBANGonline
{
    public class StartScreenManager : MonoBehaviour
    {
        void Start()
        {
            
        }

        void Update()
        {
            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if(touch.phase == TouchPhase.Began)
                {
                    SceneManager.LoadScene("Main Menu");
                }
            }
            if(Input.anyKey)
            {
                SceneManager.LoadScene("Main Menu");
            }
            if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
            {
                SceneManager.LoadScene("Main Menu");
            }
        }
    }
}