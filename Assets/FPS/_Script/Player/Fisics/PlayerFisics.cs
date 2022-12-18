using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFisics : MonoBehaviour
{

    private float pushForce = 1;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        Rigidbody rb = hit.collider.attachedRigidbody;

        if (rb != null)
        {

            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();

            rb.AddForceAtPosition(forceDirection * pushForce, transform.position, ForceMode.Impulse);

        }

        Debug.Log("Use Rigidbody");
    }
}
