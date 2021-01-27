
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody Rb;
    public float forwardForce = 500;
    public float sideMovement = 100;
    public float ScreenWidth;
   

    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        //Rb.useGravity = false;      //to use gravity function
        //Rb.AddForce(0,200,500);       // to add a push force in start 
    }

    // Update is called once per frame
    //void Update()       //for basic
    void FixedUpdate()      // for physics calculations
    {   
        Rb.AddForce(0,0,forwardForce * Time.deltaTime);   // * Time.deltaTime to make the movement consistant on each frame, each computer

        /*int i=0;

        while(i < Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > ScreenWidth/2)
            {
                Rb.AddForce(sideMovement *Time.deltaTime ,0,0, ForceMode.VelocityChange);
            }

            if(Input.GetTouch(i).position.x < ScreenWidth/2)
            {
                Rb.AddForce(-sideMovement *Time.deltaTime ,0,0, ForceMode.VelocityChange);
            }
        }  */

        if(Input.touchCount >0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            touchPosition.x = 0f;
            transform.position = touchPosition;
        }


        //if(Input.GetKey("a")){             //for pc
           // Rb.AddForce(-sideMovement *Time.deltaTime ,0,0, ForceMode.VelocityChange);
        //}

        //if(Input.GetKey("d")){          //for pc
            //Rb.AddForce(sideMovement *Time.deltaTime ,0,0, ForceMode.VelocityChange);
        //}

        if(Rb.position.y < 4f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
