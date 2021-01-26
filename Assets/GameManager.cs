
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	bool gameHasEnded = false;
	public float RestartDelay = 1f;
	public GameObject completeLevelUI;

	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}

	public void EndGame()
	{
		if(gameHasEnded == false){
			gameHasEnded = true;
			Debug.Log("Game over");
			Invoke("Restart", RestartDelay);
			//Restart(); //if needed
		}
		
	}

	void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
