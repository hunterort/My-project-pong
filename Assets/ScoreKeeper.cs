using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.LowLevelPhysics2D.PhysicsLayers;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper Instance { get; private set; }
    public int playerOneScore { get; private set; }
    public int playerTwoScore { get; private set; }

    public float score = 0f;
    public TMP_Text myPlayerOneScore;
    public TMP_Text myPlayerTwoScore;
    public TMP_Text whoWon;
    public string playerOneName = "Player One";
    public string playerTwoName = "Player Two";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        // Setup the Singleton instance
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void UpdateScorePlayerTwo()
    {
        
        playerTwoScore += 1;
        Debug.Log("PlayerTwoScore UPDTAED " + playerTwoScore);
        myPlayerTwoScore.text = playerTwoScore.ToString();
        if (playerTwoScore >= 5)
        {
            Debug.Log("Player Two WINS!");
            //whoWon.text = "Player Two Won"; //+ (playerTwoScore - playerOneScore).ToString() + " points!";
            CheckWinCondition(playerTwoScore, playerTwoName);
        }

    }
    public void UpdateScorePlayerOne()
    {
        
        playerOneScore += 1;
        Debug.Log("PlayerOneScore UPDTAED " + playerOneScore);
        myPlayerOneScore.text = playerOneScore.ToString();
        if (playerOneScore >= 5)
        {
            Debug.Log("Player One WINS!");
            //whoWon.text = "Player One Won";// + (playerOneScore - playerTwoScore).ToString() + " points!";
            CheckWinCondition(playerOneScore, playerOneName);
        }
    }
    public void CheckWinCondition(int score, string playerName)
    {

            // 1. Save the winner's name into system memory
            PlayerPrefs.SetString("WinnerName", playerName);
            PlayerPrefs.Save(); // Ensures it writes to disk immediately

            // 2. Load your Game Over scene
            SceneManager.LoadScene("GameCompleted");
        
    }




}
