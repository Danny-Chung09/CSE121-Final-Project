using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonLaunch : MonoBehaviour
{
    public GameObject cannonball;
    public Transform barrel;
    public ParticleSystem explosion;
    public ParticleSystem smoketrail;

    public Vector3 force;

    private int fired;
    // Start is called before the first frame update
    void Start()
    {
        fired = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && fired == 0) {
            GameObject bullet = Instantiate(cannonball, barrel.position, barrel.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(force, ForceMode.Impulse);
            explosion.Play();
            smoketrail.Play();
            fired = 1;
        }
    }
}
