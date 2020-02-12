using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
    public Rigidbody2D rb;
    float speed = 2f;
    public BoxCollider2D bc;

    

    // Update is called once per frame
    void FixedUpdate()
    {
        // -- transform.Translate(Vector2.down * .0000000000000000000000005f * Time.deltaTime);
        //characterController.Move(new Vector2(0, .0000000000000000000000005f * Time.deltaTime));
        
        rb.MovePosition(new Vector2(transform.position.x, transform.position.y - (speed * Time.deltaTime)));
        
        if (transform.position.y < -6)
        {
            transform.position = new Vector2(transform.position.x,5);
            GameController.UpdateScore(-10);
            
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("In trigger");
        if (collision.gameObject.tag == "Spikes")
        {
            Debug.Log("Hit by Spikes");
            transform.position = new Vector2(transform.position.x, 5);
            GameController.UpdateScore(-10);
        }
    }
}
