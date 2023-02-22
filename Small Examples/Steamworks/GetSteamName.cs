using UnityEngine;
using Steamworks;

/* Explanation
    The way we will be getting the player`s steam name is by creating a string.
	then giving the string the player name by calling the GetPersonaName() method.

    Now observe.
*/

public class GetSteamName : MonoBehaviour {

	void Start() { //Start of the the game

		if(SteamManager.Initialized) { //If the SteamManager is ready then

			string name = SteamFriends.GetPersonaName(); //Store the users name in a string
			Debug.Log(name); //Log the users name
		}
	}
}