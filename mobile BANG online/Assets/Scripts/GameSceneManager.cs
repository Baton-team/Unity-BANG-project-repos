using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.BATONteam.mobileBANGonline
{
    public class GameSceneManager : MonoBehaviour
    {
        #region MonoBehaviour Callbacks
        void Start()
        {
            
        }

        void Update()
        {

        }

        #endregion

        #region Public Method

        public void ChangeScene(SceneAsset nextScene)
        {
            SceneManager.LoadScene(nextScene.name);
        }

        #endregion
    }
}