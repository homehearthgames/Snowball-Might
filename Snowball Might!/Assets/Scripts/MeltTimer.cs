using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeltTimer : MonoBehaviour
{
    [SerializeField] float meltInterval = 10.0f;
    [SerializeField] int snowToLose = 1;
    SnowHandler snowHandler;
    void Start()
    {
        snowHandler = GetComponent<SnowHandler>();
        InvokeRepeating("MeltSnow", 0.0f, meltInterval);
    }

    void MeltSnow()
    {
        if (snowHandler.CurrentSnow > 0)
        {
            snowHandler.CurrentSnow -= snowToLose;
        }
    }
}

