using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    [SerializeField] Transform target;
   
    Vector3 offset = new Vector3(0, 1.8f, -2);

    private void LateUpdate()
    {
        if (!target) return;

        transform.position = target.position + offset;    
    }
}
