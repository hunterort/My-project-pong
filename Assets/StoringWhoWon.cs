using TMPro;
using UnityEngine;

public class StoringWhoWon : MonoBehaviour
{
    public TextMeshProUGUI whoWon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // 1. Grab the saved string out of memory. 
        // "No One" is the default fallback if the key doesn't exist.
        string winner = PlayerPrefs.GetString("WinnerName", "No One");

        // 2. Update the TextMeshPro UI element on this screen
        whoWon.text = $"{winner} Wins the Match!";
    }

    // Update is called once per frame

}
