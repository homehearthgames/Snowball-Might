using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowPickup : MonoBehaviour
{
    SnowHandler playerSnowHandler;
    

    // Start is called before the first frame update
    void Start()
    {
        playerSnowHandler = GetComponent<SnowHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Snowpile")
        {
            if (playerSnowHandler.SnowPercent != 1)
            {
                playerSnowHandler.CurrentSnow += 10;
                Destroy(other.gameObject);
            }
        }
    }
}
