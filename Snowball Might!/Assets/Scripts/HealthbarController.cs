using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarController : MonoBehaviour
{
    [SerializeField] SnowHandler playerSnowHandler;
    Image healthbarImage;
    // Start is called before the first frame update
    void Start()
    {
        healthbarImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        healthbarImage.fillAmount = 1 - playerSnowHandler.SnowPercent;
    }
}
