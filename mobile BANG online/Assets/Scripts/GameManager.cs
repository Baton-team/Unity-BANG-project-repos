using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEditor;

using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using Photon.Pun.Demo.Cockpit;

namespace Com.BATONteam.mobileBANGonline
{
    public class GameManager : MonoBehaviourPunCallbacks
    {
        #region Public Fields

        public static GameManager Instance;

        [Tooltip("The prefab to use for representing the connected player")]
        public GameObject connectedPlayerPrefab;

        [Tooltip("The prefab to use for representing the player")]
        public GameObject playerPrefab;

        #endregion

        #region Private Serializable Fields

        [Tooltip("The scene we exit in.")]
        [SerializeField]
        private string exitScene;

        [Tooltip("There we show Room Name.")]
        [SerializeField]
        private Text roomName;

        #endregion

        #region Photon Callbacks

        public override void OnLeftRoom()
        {
            SceneManager.LoadScene(exitScene);
        }

        public override void OnPlayerEnteredRoom(Player other)
        {
            Debug.LogFormat("OnPlayerEnteredRoom() {0}", other.NickName); // not seen if you're the player connecting

            if (PhotonNetwork.IsMasterClient)
            {
                Debug.LogFormat("OnPlayerEntered Room IsMasterClient {0}", PhotonNetwork.IsMasterClient); // called before OnPlayerLeftRoom

                LoadArena();
            }
        }

        public override void OnPlayerLeftRoom(Player other)
        {
            Debug.LogFormat("OnPlayerLeftRoom() {0}", other.NickName); // seen when other disconnects
            
            if (PhotonNetwork.IsMasterClient)
            {
                Debug.LogFormat("OnPlayerLeftRoom IsMasterClient {0}", PhotonNetwork.IsMasterClient); // called before OnPlayerLeftRoom
                
                LoadArena();
            }
        }

        #endregion

        #region Public Methods

        public void LeaveRoom()
        {
            PhotonNetwork.LeaveRoom();
        }

        #endregion

        #region Private Methods

        void LoadArena()
        {
            if (!PhotonNetwork.IsMasterClient)
            {
                Debug.LogError("PhotonNetwork : Trying to Load a level but we are not the master Client");
                return;
            }

            Debug.LogFormat("PhotonNetwork : Game Area");
            PhotonNetwork.LoadLevel("Game Area");
        }

        private void InstantiateConnectedPlayer()
        {
            if(connectedPlayerPrefab == null || playerPrefab == null)
            {
                Debug.LogError("<Color=Red><a>Missing</a></Color> connectedPlayerPrefab or playerPrefab Reference. Please set it up in GameObject 'Game Manager'", this);
            }
            else
            {
                Debug.LogFormat("We are Instantiating LocalPlayer from {0}", Application.loadedLevelName);
                // we're in a room. spawn a character for the local player. it gets synced by using PhotonNetwork.Instantiate
                // switch(PhotonNetwork.CurrentRoom.PlayerCount)
                // {
                //     case 1:
                //         PhotonNetwork.Instantiate(this.playerPrefab.name, PlayerSettler.new Vector2(-5f, 2f), Quaternion.identity, 0);
                //         break;
                //     case 2:
                //         PhotonNetwork.Instantiate(this.connectedPlayerPrefab.name, new Vector2(-10f, 2f), Quaternion.identity, 0);
                //         break;
                // }
                
                PhotonNetwork.Instantiate(this.connectedPlayerPrefab.name, PlayerSettler.CalculatePlayerPositions(PhotonNetwork.CurrentRoom.PlayerCount), Quaternion.identity, 0);
            }
        }

        #endregion

        #region MonoBehaviour Callbacks
        void Start()
        {
            roomName.text = PhotonNetwork.CurrentRoom.Name;
            Instance = this;

            InstantiateConnectedPlayer();
        }

        void Update()
        {

        }

        #endregion
    }
}