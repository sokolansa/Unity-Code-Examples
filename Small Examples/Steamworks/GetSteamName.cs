using UnityEngine;
using Steamworks;

/* Explanation
    The way we will be getting the player`s steam name is by creating a string.
	then giving the string the player name by calling the GetPersonaName() method.

    Now observe.
*/

public class GetSteamName : MonoBehaviour {

	void Start() { //Start of the the game

		if(SteamManager.Initialized) {

			string name = SteamFriends.GetPersonaName();
			Debug.Log(name);
		}
	}
}