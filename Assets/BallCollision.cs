using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private StartBallMovement ballMovement;
    void Start()
    {
        ballMovement = GetComponent<StartBallMovement>();
    }

    // Update is called once per frame

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision" + collision.gameObject.name);
        //if (collision.gameObject.CompareTag("PaddlePlayerOne"))
        //{
        //    Debug.Log("Collided");
        //    Destroy(myBall);
        //}
    }

    private void OnTriggerEnter2D(Collider2D other)
    { 
    
    }
}
