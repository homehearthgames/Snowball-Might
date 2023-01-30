using UnityEngine;

public class SunrayDamageController : MonoBehaviour
{
    private float damagePerSecond;

    void Start()
    {
        damagePerSecond = 1f;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SnowHandler playerSnowHandler = other.GetComponent<SnowHandler>();
            if (playerSnowHandler.SnowPercent != 0)
            {
                playerSnowHandler.CurrentSnow -= damagePerSecond * Time.deltaTime * 2;
            }
        }
    }
}
