using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    [SerializeField] SpriteRenderer spriteRenderer;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Vector3 spritePos = transform.position;
            spritePos.z = 0;

            spriteRenderer.flipX = (mousePos.x < spritePos.x);
            Debug.Log("clicked to flip");

            // Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
