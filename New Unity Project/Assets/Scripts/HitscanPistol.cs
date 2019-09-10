using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitscanPistol : MonoBehaviour
{
    public Transform gunBarrel;
    public GameObject explosion;
    public GameObject blood;
    
    

    void Update()
    {
        int layerMask = 1 << 8;
        layerMask = ~layerMask;

        if (Input.GetKey(KeyCode.Mouse0))
        {
            RaycastHit hit;


            if (Physics.Raycast(gunBarrel.position, gunBarrel.forward, out hit, Mathf.Infinity, layerMask))
            {
                Debug.DrawRay(gunBarrel.position, gunBarrel.forward * hit.distance, Color.yellow);
                GameObject explosionClone = Instantiate(explosion);
                explosion.transform.position = hit.point;
                GameObject bloodClone = Instantiate(blood);
                blood.transform.position = hit.point;
                if (hit.collider.transform.tag == "enemy")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
            else
            {
                Debug.DrawRay(gunBarrel.position, gunBarrel.forward * 9000, Color.grey);
            }

            
        }

        
       

    }
}
