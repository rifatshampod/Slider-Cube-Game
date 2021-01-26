
using UnityEngine;

public class playerCollison : MonoBehaviour
{

	public playerMovement movement;	

	void OnCollisionEnter (Collision collisionInfo)
	{
		

		if(collisionInfo.collider.tag=="obstracle"){
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}

	}
}
