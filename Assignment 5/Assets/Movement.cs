using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 30; 
   
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw ("Horizontal");
        float moveVertical = Input.GetAxisRaw ("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);
        //transform.Translate (movement * speed * Time.deltaTime, Space.World);

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
