using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform characterToFollow;

    public float followDistance = 5f;
    public float followHeight = 5f;

    public float smoothness = .1f;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 lookDir = (characterToFollow.position - transform.position).normalized;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(lookDir), smoothness);
        
        Vector3 followPoint = characterToFollow.TransformPoint(0, followHeight, followDistance);
        transform.position = Vector3.Lerp(transform.position, followPoint, smoothness);
    }
}
