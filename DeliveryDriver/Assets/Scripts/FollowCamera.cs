using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // The camera's position should be the same as the driver's position.
    [SerializeField] private GameObject follow;
    [SerializeField] private float damping = 25;

    void Update()
    {
        Vector3 targetPos = follow.transform.position;
        targetPos.z = transform.position.z; // Use my Z instead of the follow's Z.

        transform.position = Vector3.Lerp(transform.position, targetPos, damping * Time.deltaTime);
    }
}
