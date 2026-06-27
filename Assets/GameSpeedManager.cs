using UnityEngine;

public class GameSpeedManager : MonoBehaviour
{
    // This allows any script to find this manager instantly
    public static GameSpeedManager Instance { get; private set; }

    [Header("Speed Settings")]
    [Tooltip("How much speed is added to the ball on every paddle hit")]
    public float speedIncrement = .5f;

    // This is the public variable other scripts will read
    public float ExtraSpeedModifier { get; private set; } = 0f;

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

    // Public method that other scripts can call to increase the speed
    public void IncreaseGameSpeed()
    {
        
        ExtraSpeedModifier += speedIncrement;
        //Debug.Log($"Ball hit! Current Extra Speed: {ExtraSpeedModifier}");

    }

    // Call this when a point is scored to reset the rally speed
    public void ResetSpeed()
    {
        ExtraSpeedModifier = 0f;
    }
}