using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEditor;

using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

namespace Com.BATONteam.mobileBANGonline
{
    public class PlayerManager : MonoBehaviour
    {
        #region Private Fields

        private int Health = 5;
        private PhotonView photonView;

        #endregion

        #region MonoBehaviour Callbacks
        void Start()
        {
            
        }

        void Update()
        {
            if(photonView.IsMine)
            {
                if(Health <= 0)
                {
                    GameManager.Instance.LeaveRoom();
                }
            }
        }

        #endregion
    }
}