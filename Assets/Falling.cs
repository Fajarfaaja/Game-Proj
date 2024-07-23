using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    // Referensi ke panel "GameFinished"
    public GameObject GameOver;
    public GameObject followCamera;
    public GameObject gunShoot;
    public GameObject PlayerArmature;

    // Method ini dipanggil saat ada objek yang memasuki trigger
    void OnTriggerEnter(Collider other)
    {
        // Periksa apakah objek yang memasuki trigger memiliki tag "Player"
        if (other.CompareTag("Player"))
        {
            // Aktifkan panel "GameFinished"
            GameOver.SetActive(true);

            // Nonaktifkan followCamera, gunShoot, dan PlayerArmature
            if (followCamera != null)
            {
                followCamera.SetActive(false);
            }

            if (gunShoot != null)
            {
                gunShoot.SetActive(false);
            }

            if (PlayerArmature != null)
            {
                PlayerArmature.SetActive(false);
            }
        }
    }

    public void Ignore()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;

        // Nonaktifkan followCamera, gunShoot, dan PlayerArmature
        if (followCamera != null)
        {
            followCamera.SetActive(false);
        }

        if (gunShoot != null)
        {
            gunShoot.SetActive(false);
        }

        if (PlayerArmature != null)
        {
            PlayerArmature.SetActive(false);
        }
    }
}
