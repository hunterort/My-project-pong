using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper Instance { get; private set; }
    public int playerOneScore { get; private set; }
    public int playerTwoScore { get; private set; }

    public float score = 0f;
    public TMP_Text myPlayerOneScore;
    public TMP_Text myPlayerTwoScore;
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
        myPlayerOneScore.text = playerTwoScore.ToString();

    }
    public void UpdateScorePlayerOne()
    {
        
        playerOneScore += 1;
        Debug.Log("PlayerOneScore UPDTAED " + playerOneScore);
        myPlayerTwoScore.text = playerTwoScore.ToString();

    }

}
