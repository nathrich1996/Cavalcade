using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isRight;
    public Rigidbody2D rb;
    public BoxCollider2D bc;

    bool isMoving;
    float targetPosition;
    float speed = 8f;
    void Start()
    {
        isMoving = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isMoving)
        {
            ToggleSpikes();
        }
        MoveToTarget();
    }
    void ToggleSpikes()
    {
        isMoving = true;
        if (isRight) //if right side
        {
            isRight = false; //go left
            targetPosition = -4f;
        }
        else //if left side
        {
            isRight = true; //go right
            targetPosition = 5f;
        }
    }
    void MoveToTarget()
    {
        if (isRight && isMoving) //if moving right
        {
            if(transform.position.x < targetPosition)
            {
                rb.MovePosition(new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y));
            }
            else
            {
                rb.MovePosition(new Vector2(targetPosition, transform.position.y));
                isMoving = false;
            }
            Debug.Log("Moving Right");
        }
        else if (!isRight && isMoving)
        {
            if(transform.position.x > targetPosition && isMoving)
            {
                rb.MovePosition(new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y));
            }
            else
            {
                rb.MovePosition(new Vector2(targetPosition, transform.position.y));
                isMoving = false;
            }
            Debug.Log("Moving Left");
        }
    }
}
