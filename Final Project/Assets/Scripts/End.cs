using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class End : MonoBehaviour
{
    public List<Light> Lights;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "PowerStrip") {
            foreach (Light i in Lights) {
                i.intensity = 0;
            }
        }
    }
}
