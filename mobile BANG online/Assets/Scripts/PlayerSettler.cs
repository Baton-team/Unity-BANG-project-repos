using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEditor;

using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

namespace Com.BATONteam.mobileBANGonline
{
	static class PlayerSettler
	{
		#region Public Methods

		public static Vector2 CalculatePlayerPositions(int playerCount)
		{
			Vector2 positions = new Vector2(0,0);

			switch(playerCount)
			{
				case 2: positions.y = 2; positions.x = -8;
				break;
				case 3: positions.y = 0; positions.x = -8;
				break;
				case 4: positions.y = 2; positions.x = 8;
				break;
				case 5: positions.y = 0; positions.x = 8;
				break;
			}

			return positions;
		}

		#endregion
	}
}