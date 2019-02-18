using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoRedFromBlue : MonoBehaviour
{
    public Transform destination; 
    public Camera[] cams;

    public void camMainMove(){
        cams[0].enabled = true;
        cams[1].enabled = false;
        cams[2].enabled = false;
    }
    public void camRedMove(){
        cams[0].enabled = false;
        cams[1].enabled = true; 
        cams[2].enabled = false;
    }
    public void camBlueMove(){
        cams[0].enabled = false;
        cams[1].enabled = false; 
        cams[2].enabled = true;
    }

    void Awake(){
        destination = GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            other.transform.position = new Vector3(-5.57f,1.51f,-15.38f);//destination.position;
            camRedMove();
        }
    }


}
