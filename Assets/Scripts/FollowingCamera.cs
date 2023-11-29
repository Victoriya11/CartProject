using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    [SerializeField] Transform target;
   
    Vector3 offset = new Vector3(0, 1.8f, -2);
    float posX = 1.5f;
    Vector3 newPos;

    private void Update()
    {
        newPos = new Vector3(posX, target.position.y, target.position.z);
    }

    private void LateUpdate()
    {
        transform.position = newPos + offset;    
    }
}
