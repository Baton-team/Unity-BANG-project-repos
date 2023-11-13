using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

using Photon.Pun;
using Photon.Realtime;

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Com.BATONteam.mobileBANGonline
{
    public class Launcher : MonoBehaviourPunCallbacks
    {
        #region Private Serializable Fields

        /// <summary>
        /// The maximum number of players per room. When a room is full, it can't be joined by new players, and so new room will be created.
        /// </summary>
        [Tooltip("The maximum number of players per room. When a room is full, it can't be joined by new players, and so new room will be created")]
        [SerializeField]
        private byte maxPlayersPerRoom = 4;

        /// <summary>
        /// The Input Field where we text host room name.
        /// </summary>
        [Tooltip("The Input Field where we text host room name we join")]
        [SerializeField]
        private InputField joinRoomNameInputField;

        [Tooltip("The Input Field where we text host room name")]
        [SerializeField]
        private InputField createRoomNameInputField;

        [Tooltip("The Ui Panel to let the user enter name, connect and play")]
        [SerializeField]
        private GameObject controlPanel;
        [Tooltip("The UI Label to inform the user that the connection is in progress")]
        [SerializeField]
        private GameObject progressLabel;

        #endregion

        #region Private Fields

        /// <summary>
        /// This client's version number. Users are separated from each other by gameVersion (which allows you to make breaking changes).
        /// </summary>
        string gameVersion = "1";

        #endregion

        #region MonoBehaviour CallBacks

        /// <summary>
        /// MonoBehaviour method called on GameObject by Unity during early initialization phase.
        /// </summary>
        void Awake()
        {
            // #Critical
            // this makes sure we can use PhotonNetwork.LoadLevel() on the master client and all clients in the same room sync their level automatically
            PhotonNetwork.AutomaticallySyncScene = true;
        }

        /// <summary>
        /// MonoBehaviour method called on GameObject by Unity during initialization phase.
        /// </summary>
        void Start()
        {
            progressLabel.SetActive(false);
            controlPanel.SetActive(true);
            
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.GameVersion = gameVersion;
            PhotonNetwork.JoinLobby();

            LogsManager.WriteLog("==================================\nOnline Launcher: is started.");
        }

        #endregion

        #region MonoBehaviourPunCallbacks Callbacks
        public override void OnJoinedLobby()
        {
           LogsManager.WriteLog("We are joined to Lobby.");
        }

        public override void OnDisconnected(DisconnectCause cause)
        {
            string log = "Launcher: OnDisconnected() was called by PUN with reason " + cause;
            LogsManager.WriteLog(log);

            progressLabel.SetActive(false);
            controlPanel.SetActive(true);
        }

        public override void OnJoinRandomFailed(short returnCode, string message)
        {
            LogsManager.WriteLog("Launcher:OnJoinRandomFailed() was called by PUN. No random room available, so we create one.\nCalling: PhotonNetwork.CreateRoom");

            // #Critical: we failed to join a random room, maybe none exists or they are all full. No worries, we create a new room.
            PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = maxPlayersPerRoom });
        }

        public override void OnJoinedRoom()
        {
            LogsManager.WriteLog("Launcher: OnJoinedRoom() called by PUN. Now this client is in a room.");

            PhotonNetwork.LoadLevel("Game Area");
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Start the connection process.
        /// - If already connected, we attempt joining a random room
        /// - if not yet connected, Connect this application instance to Photon Cloud Network
        /// </summary>
        public void ConnectToRandomRoom()
        {
            LogsManager.WriteLog("Launcher: It's connecting to the random room..." + Convert.ToString(PhotonNetwork.IsConnected));  

            progressLabel.SetActive(true);
            controlPanel.SetActive(false);     

            // we check if we are connected or not, we join if we are , else we initiate the connection to the server.
            if (PhotonNetwork.IsConnected)
            {
                // #Critical we need at this point to attempt joining a Random Room. If it fails, we'll get notified in OnJoinRandomFailed() and we'll create one.
                PhotonNetwork.JoinRandomRoom();
            }
            else
            {
                LogsManager.WriteLog("IS NOT CONNECTED");
                // #Critical, we must first and foremost connect to Photon Online Server.
                PhotonNetwork.ConnectUsingSettings();
                PhotonNetwork.GameVersion = gameVersion;
            }
        }

        public void ConnectToSpecificRoom()
        {
            LogsManager.WriteLog("Launcher: It's connecting to the specific room..." + Convert.ToString(PhotonNetwork.IsConnected));

            progressLabel.SetActive(true);
            controlPanel.SetActive(false);

            if (PhotonNetwork.IsConnected)
            {
                if (joinRoomNameInputField.text == "")
                {
                    ConnectToRandomRoom();
                }
                else
                {
                    PhotonNetwork.JoinRoom(joinRoomNameInputField.text);
                }
            }
            else
            {
                LogsManager.WriteLog("IS NOT CONNECTED");
                PhotonNetwork.ConnectUsingSettings();
                PhotonNetwork.GameVersion = gameVersion;
            }
        }

        public void CreateHostRoom()
        {
            LogsManager.WriteLog("Launcher: It's creating host room..." + Convert.ToString(PhotonNetwork.IsConnected));

            progressLabel.SetActive(true);
            controlPanel.SetActive(false);  

            if (PhotonNetwork.IsConnected)
            {
                if(createRoomNameInputField.text != "")
                {
                    PhotonNetwork.CreateRoom(createRoomNameInputField.text, new RoomOptions { MaxPlayers = maxPlayersPerRoom });
                }
                else
                {
                    PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = maxPlayersPerRoom });
                }
            }
            else
            {
                LogsManager.WriteLog("IS NOT CONNECTED");
                PhotonNetwork.ConnectUsingSettings();
                PhotonNetwork.GameVersion = gameVersion;
            }
        }

    #endregion

    }
}