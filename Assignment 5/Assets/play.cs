using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public GameObject particle;
    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    { 
        particle.GetComponent<ParticleSystem>().Stop();  
    }

    void Update(){
        if(portal.GetComponent<GoRed>().points > 0 && !particle.GetComponent<ParticleSystem>().isPlaying){ 
            particle.GetComponent<ParticleSystem>().Play();
        }
    }
    
}
