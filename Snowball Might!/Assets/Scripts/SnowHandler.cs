using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowHandler : MonoBehaviour
{

    [SerializeField] float currentSnow;
    public float CurrentSnow
    {
        get { return currentSnow; }
        set { currentSnow = value; }
    }
    [SerializeField] float maxSnow;
    public float MaxSnow
    {
        get { return maxSnow; }
        set { maxSnow = value; }
    }

    [SerializeField] float snowPercent;
    public float SnowPercent
    {
        get { return snowPercent; }
    }
    
    void Awake()
    {
        snowPercent = currentSnow / maxSnow;
    }

    // Update is called once per frame
    void Update()
    {
        snowPercent = currentSnow / maxSnow;
    }
}
