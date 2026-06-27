using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class StartBallMovement : MonoBehaviour
{

    public float myBallSpeed = 1f;
    private float myBallRandomDirectionNum = 0f;
    private int myBallDirection = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && myBallRandomDirectionNum == 0f)
        {
            
            if (myBallDirection == 0)
            {
                myBallRandomDirectionNum = Random.Range(-1, 1);
            }

            if (myBallRandomDirectionNum >= 0f)
            {
                myBallDirection = -1;
            }
            else if (myBallRandomDirectionNum <= 0f)
            {
                myBallDirection = -1;
            }
        }
    }

    void FixedUpdate()
    {
        Vector2 myBallVector = new Vector2(myBallSpeed * myBallDirection, 0f);
        //myBall.linearVelocity = myBallVector;
        transform.Translate(myBallVector);
    }


}
