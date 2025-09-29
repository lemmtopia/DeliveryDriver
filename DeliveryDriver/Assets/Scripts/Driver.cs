using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float baseMoveSpeed = 10f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 20f;

    float speedChangeDelay = 0;

    void Update()
    {
        speedChangeDelay -= Time.deltaTime;
        if (speedChangeDelay <= 0)
        {
            // Revert to normal speed.
            moveSpeed = baseMoveSpeed;
        }

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;

        transform.Rotate(0, 0, -steerAmount * Time.deltaTime);
        transform.Translate(0, moveAmount * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            speedChangeDelay = 1f;
        }
        else if (other.tag == "Slow")
        {
            moveSpeed = slowSpeed;
            speedChangeDelay = 1f;
        }
	}
}
