using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTwoMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float paddleSpeed = 20f;
    Rigidbody2D myPlayerTwoPaddle;



    void Start()
    {
        myPlayerTwoPaddle = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Vector2 ballPosition = BallController.Instance.Position;
        float distanceY = ballPosition.y - transform.position.y;

        // 2. Add a small deadzone (0.1f) to stop jittering when perfectly aligned
        if (Mathf.Abs(distanceY) > 0.1f)
        {
            // Get direction: returns 1 if ball is above, -1 if below
            float directionY = Mathf.Sign(distanceY);

            // 3. Apply a perfectly constant velocity
            myPlayerTwoPaddle.linearVelocity = new Vector2(0f, directionY * paddleSpeed);
        }
        else
        {
            // Stop moving when the paddle is aligned with the ball
            myPlayerTwoPaddle.linearVelocity = Vector2.zero;
        }

    }


}
