using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instruction : MonoBehaviour
{
    public GameObject playGame;
    public GameObject followCamera;
    public GameObject gunShoot;
    // Start is called before the first frame update
    void Start()
    {
        playGame.SetActive(true);
        followCamera.SetActive(false);
        gunShoot.SetActive(false);
        Time.timeScale = 0f;
    }
    
    public void Play()
    {
        playGame.SetActive(false);
        followCamera.SetActive(true);
        gunShoot.SetActive(true);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
