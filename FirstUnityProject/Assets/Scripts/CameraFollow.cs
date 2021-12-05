using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform characterToFollow;

    public float followDistance = 10f;

    public float smoothness = .1f;
    // Update is called once per frame
    void Update()
    {
        Vector3 followTargetPosition = characterToFollow.position + -characterToFollow.forward * followDistance;
        followTargetPosition.y = 4.5f;
        if (Vector3.Distance(characterToFollow.position, transform.position) > followDistance)
        {
            transform.position = Vector3.Lerp(transform.position, followTargetPosition, smoothness);
        }

        
        transform.LookAt(characterToFollow.TransformPoint(characterToFollow.forward));
    }
}
