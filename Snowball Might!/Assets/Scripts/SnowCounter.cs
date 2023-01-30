using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SnowCounter : MonoBehaviour
{
    [SerializeField] SnowHandler playerSnowHandler;
    TextMeshProUGUI snowCounterText;
    // Start is called before the first frame update
    void Awake()
    {
        snowCounterText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        snowCounterText.text = ((1 - playerSnowHandler.SnowPercent) * 100).ToString("0") + "°";
    }
}
