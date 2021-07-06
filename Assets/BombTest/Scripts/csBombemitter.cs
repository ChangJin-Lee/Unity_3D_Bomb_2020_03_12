using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csBombemitter : MonoBehaviour
{
    public GameObject bombPrefab;

    float BOMB_DELAY = 5;

    float bombDelay;

    // Start is called before the first frame update
    void Start()
    {
        bombDelay = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        bombDelay -= Time.deltaTime;
        
        if (bombDelay <= 0)
        {
            Instantiate(bombPrefab, bombPrefab.transform.position, bombPrefab.transform.rotation);

            BOMB_DELAY = Mathf.Clamp(BOMB_DELAY*0.99f, 0.9f, 5);
            bombDelay = BOMB_DELAY;
        }
    }
}
