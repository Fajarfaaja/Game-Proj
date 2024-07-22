using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadEnvironmentScene()
    {
        SceneManager.LoadScene("Environment"); // Ganti "Environment" dengan nama scene yang sesuai
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("WelcomePage"); // Ganti "Environment" dengan nama scene yang sesuai
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public GameObject creditPanel;
    public GameObject instructionPanel;

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

    public void ShowInstruction()
    {
        if (creditPanel != null)
        {
            instructionPanel.SetActive(true); // Menampilkan panel kredit
        }
    }

    public void HideInstruction()
    {
        if (creditPanel != null)
        {
            instructionPanel.SetActive(false); // Menyembunyikan panel kredit
        }
    }


}
