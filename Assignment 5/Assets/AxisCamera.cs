using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisCamera : MonoBehaviour
{
    public Transform targetTransform;

    void LateUpdate() {
        Vector3 relativePos = targetTransform.position - transform.position;
        relativePos.y = 0; 
        transform.rotation = Quaternion.LookRotation(relativePos);
    }
}
