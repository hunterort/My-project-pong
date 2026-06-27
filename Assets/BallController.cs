using UnityEngine;

public class BallController : MonoBehaviour
{
    // 1. Create a static instance so other scripts can access this one
    public static BallController Instance { get; private set; }

    private void Awake()
    {
        // 2. Ensure only one instance of the ball exists
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 3. Helper property to get the ball's location
    public Vector2 Position
    {
        get { return transform.position; }
    }
}