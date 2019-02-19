using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    public GameObject portal;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.name == "Player"){
            portal.GetComponent<GoRed>().points++;
            Destroy(gameObject);
        }
    }
}
