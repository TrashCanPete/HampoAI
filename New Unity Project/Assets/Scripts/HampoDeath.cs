using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HampoDeath : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "player")
        {
            Debug.Log("actu");
            GameManager.instance.CheckGameOver();
        }
            
    }

    
}