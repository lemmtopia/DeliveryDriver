using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(255, 255, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

    bool hasPackage = false;

    SpriteRenderer spriteRenderer;

	void Start()
	{
        // Getting my sprite renderer component.
        spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("Bump!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;

            // Changing my color
            spriteRenderer.color = hasPackageColor;

            // Destroying the package
            Destroy(other.gameObject);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;

            // Turning back to normal color
            spriteRenderer.color = noPackageColor;
        }
	}
}
