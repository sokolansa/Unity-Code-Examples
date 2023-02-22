using UnityEngine;
using Steamworks;

/* Explanation
    The way we are going to implement steam achivements is by calling the GetAchievement() method.
    then giving it a "API Name" to get a reference to the achivement we want to use.
    after that we give it a bool so it can give us the status of the achivement.
    now we check if the achivement has already been given before if not then give the achivement.

    Now observe.
*/

public class Achivement : MonoBehaviour {

    public bool tutorialCompleted; //This bool will be used for getting the status of the achivement

	void Start() { //Start of the the game

		if(SteamManager.Initialized) { //If the SteamManager has been loaded then

            //Get the status of the achivement
            Steamworks.SteamUserStats.GetAchievement("tutorial", out tutorialCompleted);

            if (!tutorialCompleted) //If we don`t have this achivement then
            {
                Steamworks.SteamUserStats.SetAchievement("tutorial"); //Give the achivement
            }
		}
	}
}