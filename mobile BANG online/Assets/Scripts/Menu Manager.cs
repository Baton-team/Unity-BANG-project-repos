using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.BATONteam.mobileBANGonline
{
    public class MenuManager : MonoBehaviour
    {
        #region MonoBehaviour Callbacks
        
        void Start()
        {
            
        }

        void Update()
        {
            
        }

        #endregion

        #region Public Methods

        public void ChangeScene(SceneAsset nextScene)
        {
            SceneManager.LoadScene(nextScene.name);
        }

        #endregion
    }
}