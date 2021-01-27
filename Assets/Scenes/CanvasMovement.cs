
using UnityEngine;

public class CanvasMovement : MonoBehaviour
{
    public Rigidbody Rb;
    public float sideMovement = 100;

        public void goLeft()
    {
        Rb.AddForce(-sideMovement *Time.deltaTime ,0,0, ForceMode.VelocityChange);
    }

    public void goRight()
    {
        Rb.AddForce(sideMovement *Time.deltaTime ,0,0, ForceMode.VelocityChange);
    }
}
