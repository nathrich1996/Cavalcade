using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    
    public static Vector2 bottomLeft;
    public static Vector2 topRight;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height));
        Instantiate (ball);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
