using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.BATONteam.mobileBANGonline
{
    public class StartScreenManager : MonoBehaviour
    {
        #region Public Fields

        [Tooltip("The next Scene after Start Screen.")]
        [SerializeField]
        private SceneAsset nextScene;

        #endregion

        #region MonoBehaviour Callbacks
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
                    SceneManager.LoadScene(nextScene.name);
                }
            }
            if(Input.anyKey)
            {
                SceneManager.LoadScene(nextScene.name);
            }
            if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
            {
                SceneManager.LoadScene(nextScene.name);
            }
        }

        #endregion
    }
}