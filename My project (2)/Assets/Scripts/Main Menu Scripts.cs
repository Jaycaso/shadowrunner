using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // This will be called when the Play button is clicked
    public void StartGame()
    {
        // Load the game scene (replace "GameScene" with the name of your actual game scene)
        SceneManager.LoadScene("SampleScene");
    }

    // This will be called when the Quit button is clicked
    public void QuitGame()
    {
        // This will quit the game when you're in a build (not in the editor)
        Debug.Log("Quit Game");
        Application.Quit();
    }
}