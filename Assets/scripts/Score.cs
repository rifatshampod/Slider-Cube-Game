using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public Transform player;
    public Text scoreText;
    public float scoreValue;

    // Update is called once per frame
    void Update()
    {
        scoreValue = player.position.z + 46;
        scoreText.text = scoreValue.ToString("0");
    }
}
