using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject youWon;
    public GameObject gameOver;
    public GameObject Hampo;
    public GameObject player;
    public static GameManager instance = null;

    // Start is called before the first frame update
    void Start()
    {
        if (instance = null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void CheckGameOver()
    {
        Debug.Log("diediedie");
        gameOver.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
