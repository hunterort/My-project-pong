using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class BallMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D myBall;
    public float ballYPosition;
    public float ballXPosition;

    

    void Start()
    {
        myBall = GetComponent<Rigidbody2D>();
        LaunchBall();
    }
    void Update() 
    {
        ballYPosition = myBall.transform.position.y;
        ballXPosition = myBall.transform.position.y;

    }

    void LaunchBall()
    {
            
        
        transform.position = Vector2.zero;

        // Launch horizontally to start (either left or right)
        //float xDirection = Random.Range(0, 2) == 0 ? -1f : 1f;
        float xDirection = -1f;
        myBall.linearVelocity = new Vector2(xDirection, 0f) * speed;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Object Collision: " + collision.gameObject.name);
        // Ensure we are bouncing off a paddle
        //if (collision.gameObject.CompareTag("PaddlePlayerOneTag"))
        //{
        //    Destroy(myBall);
        //}
        if (collision.gameObject.CompareTag("PaddlePlayerOneTag") || collision.gameObject.CompareTag("PaddlePlayerTwoTag") )
        {
            float ballYPosition = transform.position.y;
            //Debug.Log("ballyPosition " + ballYPosition);
            float paddlePosition = collision.transform.position.y;
            //Debug.Log("paddlePosition " + paddlePosition);
            float paddleHeight = collision.collider.bounds.size.y;
            //Debug.Log("paddleHeight" + paddleHeight);
            float hitPointY = (ballYPosition - paddlePosition) / paddleHeight;

            //Debug.Log("(ballYPosition - paddlePosition) / paddleHeight " + hitPointY);

            //float xDirection = (myBall.linearVelocity.x > 0f) ? -1f : 1f;
            float xDirection;
            if (myBall.linearVelocity.x > 0f)
            {
                xDirection = -1f;
            }
            else
            {
                xDirection = 1f;
            }

            Vector2 ballVector = new Vector2(xDirection*speed, hitPointY*speed);

            //myBall.linearVelocity = ballVector;
            //// 🚀 CALLING FROM ANOTHER SCRIPT: One simple line!
            //GameSpeedManager.Instance.IncreaseGameSpeed();

            // Immediately apply the newly updated speed to this ball's velocity
            ApplyUpdatedSpeed();
        }

        //|| collision.gameObject.CompareTag("WallBottomTag")
        else if (collision.gameObject.CompareTag("WallTopTag") )
        {
            //Debug.Log("collision " + collision.gameObject.name);
            //Debug.Log("x " + myBall.linearVelocity.x);
            //Debug.Log("x " + myBall.linearVelocity.y);
            //float xDirection = (myBall.linearVelocity.x > 0f) ? -1f : 1f;
            float yDirection;
            if (myBall.linearVelocity.y > 0f)
            {
                yDirection = -1f;
            }
            else
            {
                yDirection = 1f;
            }

            Vector2 ballVector = new Vector2(myBall.linearVelocity.x, yDirection * myBall.linearVelocity.y);
            myBall.linearVelocity = ballVector;
        }



    }
    private void ApplyUpdatedSpeed()
    {

        // Get the direction the ball is already traveling
        Vector2 direction = myBall.linearVelocity.normalized;

        // Calculate new speed: Base Speed + the Modifier from our Manager
        float baseSpeed = 10f;
        // float currentTotalSpeed = baseSpeed + GameSpeedManager.Instance.ExtraSpeedModifier;

        // Apply it
        //myBall.linearVelocity = direction * currentTotalSpeed;
        //Debug.Log("New Game Speed: " + currentTotalSpeed);
    }
}