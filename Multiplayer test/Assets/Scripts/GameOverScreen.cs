using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject pointsText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoretext;
    private int score;
     void Start()
    {

        gameOverText.gameObject.SetActive(true);
       
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("StartGame");
    }
    
    public void ExitButtion()
    {
        SceneManager.LoadScene("StartGame");
    }
}
