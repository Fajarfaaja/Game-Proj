using System.Collections;
using UnityEngine;

public class HandleGameOver : MonoBehaviour
{
    public AudioSource audioSource; // Referensi ke AudioSource
    public GameObject gameOverPanel; // Referensi ke GameOverPanel

    // Metode untuk mengaktifkan panel GameOver dan memutar audio
    public void TriggerGameOver()
    {
        // Aktifkan GameOverPanel
        gameOverPanel.SetActive(true);

        // Memutar audio jika AudioSource tidak null
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // Menonaktifkan objek lain seperti 'PlayerArmature' jika diperlukan
        // GameObject.Find("PlayerArmature").SetActive(false); // Sesuaikan dengan kebutuhan Anda
    }
}
