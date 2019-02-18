using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 50; 
   
    // Update is called once per frame
    void FixedUpdate()
    {
         if (Input.GetKey(KeyCode.A)){
             rb.AddForce(speed,0,0);
         }
         if (Input.GetKey(KeyCode.D)){
             rb.AddForce(-speed,0,0);
         }
         if (Input.GetKey(KeyCode.W)){
             rb.AddForce(0,0,-speed);
         }
         if (Input.GetKey(KeyCode.S)){
             rb.AddForce(0,0,speed);
         }
    }
}
