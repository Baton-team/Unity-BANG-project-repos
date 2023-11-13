using UnityEngine.SceneManagement;
using UnityEngine;

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

        public void ChangeScene(string nextSceneName)
        {
            SceneManager.LoadScene(nextSceneName);
        }

        #endregion
    }
}