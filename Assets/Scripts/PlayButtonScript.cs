using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    public GameObject menu;
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(RestartGame);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        menu.SetActive(false);
        ScoreScript.scoreValue = 0;
    }
}
