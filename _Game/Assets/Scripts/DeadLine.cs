using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       // Destroy(collision.gameObject);
        other.gameObject.transform.localPosition = new Vector3(30, 1, 1);

    }
}
