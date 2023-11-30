using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEditor;

using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

namespace Com.BATONteam.mobileBANGonline
{
	public class PlayerSettler : MonoBehaviour
	{
		#region Public Methods

		public Vector2 GetPosition()
		{
			return transform.position;
		}

		#endregion
	}
}