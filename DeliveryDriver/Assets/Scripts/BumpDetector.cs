using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bump!");
    }

	void OnTriggerEnter2D(Collider2D collision)
	{
        Debug.Log("Bump on Trigger!");
	}
}
