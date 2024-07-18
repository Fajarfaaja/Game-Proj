using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMaster : MonoBehaviour
{
    public GameObject canvas;
    public bool gameStarted = false;

    public void PlayerReady()
    {
        gameStarted = true;
        canvas.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //canvas.SetActive(true);
    }
}
