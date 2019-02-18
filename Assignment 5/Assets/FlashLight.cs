using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    private Vector3 vectOffset;
    public GameObject goFollow;
    private Light myLight;
    [SerializeField] private float speed = 3.0f;


 

    


    // Start is called before the first frame update
    void Start()
    {
        vectOffset = transform.position - goFollow.transform.position;
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
    
        transform.position = goFollow.transform.position; // + vectOffset;
        //transform.rotation = Quaternion.Slerp(transform.rotation, goFollow.transform.rotation, speed * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.Space)) {
            myLight.enabled = !myLight.enabled;
        }

    }
}
