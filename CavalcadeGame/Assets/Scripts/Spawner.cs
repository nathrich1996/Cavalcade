using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawnee;
    float[] spawnPositions = { -3f, -1f, 1f, 3f };
    float timer;
    void Start()
    {
        timer = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.0f)
        {
            GameObject rt = Instantiate(spawnee) as GameObject;
            int chosenIndex = Random.Range(0, spawnPositions.Length);
            float chosenposition = spawnPositions[chosenIndex];
            rt.transform.position = new Vector2(chosenposition, 5f);
            if (rt.transform.position.y < -6)
            {
                Destroy(rt);
                GameController.UpdateScore(-10);
            }
            timer = 0;
        }
    }
}
