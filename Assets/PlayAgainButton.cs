using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{

    public void OnPlayAgainButtonClick()
    {
        SceneManager.LoadScene("Game");
    }


}
