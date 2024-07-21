using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadEnvironmentScene()
    {
        SceneManager.LoadScene("Environment"); // Ganti "Environment" dengan nama scene yang sesuai
    }

    public void BackInCredit()
    {
        SceneManager.LoadScene("WelcomePage"); // Ganti "Environment" dengan nama scene yang sesuai
    }

    public GameObject creditPanel;

    public void ShowCredit()
    {
        if (creditPanel != null)
        {
            creditPanel.SetActive(true); // Menampilkan panel kredit
        }
    }

    public void HideCredit()
    {
        if (creditPanel != null)
        {
            creditPanel.SetActive(false); // Menyembunyikan panel kredit
        }
    }
}
