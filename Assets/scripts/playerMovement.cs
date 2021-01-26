
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody Rb;
    public float forwardForce = 500;
    public float sideMovement = 100;

    // Start is called before the first frame update
    void Start()
    {
        //Rb.useGravity = false;      //to use gravity function
        //Rb.AddForce(0,200,500);       // to add a push force in start 
    }

    // Update is called once per frame
    //void Update()       //for basic
    void FixedUpdate()      // for physics calculations
    {   
        Rb.AddForce(0,0,forwardForce * Time.deltaTime);   // * Time.deltaTime to make the movement consistant on each frame, each computer

        if(Input.GetKey("a")){
            Rb.AddForce(-sideMovement *Time.deltaTime ,0,0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("d")){
            Rb.AddForce(sideMovement *Time.deltaTime ,0,0, ForceMode.VelocityChange);
        }

        if(Rb.position.y < 4f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
