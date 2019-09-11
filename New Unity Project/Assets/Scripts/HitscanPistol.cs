using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitscanPistol : MonoBehaviour
{
    public Transform gunBarrel;

    public GameObject blood;

    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;

    public ParticleSystem muzzleFlash;

    void Update()
    {
        int layerMask = 1 << 8;
        layerMask = ~layerMask;

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        void Shoot()
        {
            muzzleFlash.Play();
            RaycastHit hit;
            if (Physics.Raycast(gunBarrel.position, gunBarrel.forward, out hit, Mathf.Infinity, layerMask))
            {
                Debug.DrawRay(gunBarrel.position, gunBarrel.forward * hit.distance, Color.yellow);

                Target target = hit.transform.GetComponent<Target>();
                if (target!= null)
                {
                    target.TakeDamage(damage);
                }

                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * (impactForce));
                }

                GameObject bloodGO = Instantiate(blood, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(bloodGO, 2f);

            }
            else
            {
                Debug.DrawRay(gunBarrel.position, gunBarrel.forward * 9000, Color.grey);
            }
        }
    }
}
