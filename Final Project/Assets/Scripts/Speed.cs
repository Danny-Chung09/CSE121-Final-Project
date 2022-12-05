using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public GameObject g_object;
    public Vector3 force;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == g_object) {
            col.gameObject.GetComponent<Rigidbody>().AddForce(force, ForceMode.Acceleration);
        }
    }
}
