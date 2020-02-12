using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float speed;
    
    float radius;
    Vector2 direction;
    Vector3 mou;
    float score;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.one.normalized; //direction is (1,1) normalized?
        radius = transform.localScale.x/2; //half the width of the ball
        score = 0;
    }


    void Update()
    {
        //I want to up speed if click and give the user a point
    

      mou = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      if(Input.GetMouseButtonDown(0) && mou.x < transform.position.x+radius && mou.x > transform.position.x-radius && mou.y < transform.position.y+radius && mou.y > transform.position.y-radius){
      print("FASTER!");
      speed= speed+1;
      score = score + speed;
      print (score);
      
      
      }
    
    
      transform.Translate (direction*speed*Time.deltaTime);
      
 
      
      if(transform.position.y < GameManager.bottomLeft.y + radius && direction.y < 0) {
      direction.y = -direction.y;
      }
      if(transform.position.y > GameManager.topRight.y - radius && direction.y > 0){
      direction.y = -direction.y;
      }
      if(transform.position.x < GameManager.bottomLeft.x + radius && direction.x < 0){
      direction.x = -direction.x;
      }
      if(transform.position.x > GameManager.topRight.x - radius && direction.x > 0){
      direction.x = -direction.x;
      }
    }
}
