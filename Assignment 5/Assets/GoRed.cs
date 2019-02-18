using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoRed : MonoBehaviour
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
            other.transform.position = new Vector3(-0.56f,1.51f,-12.44f);//destination.position;
            camRedMove();
        }
    }


}
