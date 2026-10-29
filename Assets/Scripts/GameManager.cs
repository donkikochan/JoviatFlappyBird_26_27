using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int score = 0;
    public GameObject gameOverPanel;
    public GameObject pipeSpawner;
    public TextMeshProUGUI  scoreText;
    void Start()
    {
        gameOverPanel.SetActive(false);
        UpdateScoreInfo();

    }

    void UpdateScoreInfo()
    {
        scoreText.SetText("Score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreInfo();
        Debug.Log(score);
    }


    public void StopGame()
    {
        Debug.Log("Game stopped");
        gameOverPanel.SetActive(true);
        
        
        //Buscar todos los pipe y destruir su componente Pipe
        GameObject[] pipes = GameObject.FindGameObjectsWithTag("PIPE");
        foreach (GameObject pip in pipes)
        {
            Destroy(pip.GetComponent<Pipe>());
        }
        Destroy(pipeSpawner.GetComponent<PipeSpawner>());
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
