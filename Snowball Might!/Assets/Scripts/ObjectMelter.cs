using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMelter : MonoBehaviour
{
    SnowHandler snowHandler;
    // Start is called before the first frame update
    void Start()
    {
        snowHandler = GetComponent<SnowHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (snowHandler.SnowPercent == 0)
        {
            Destroy(gameObject);
        }
    }
}
