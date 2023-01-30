using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    [SerializeField] SnowHandler snowHandler;
    [SerializeField] PlayerMovement playerMovement;
    Animator snowmanAnimator;

    // Start is called before the first frame update
    void Start()
    {
        snowmanAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        snowmanAnimator.SetFloat("Snow", snowHandler.SnowPercent);
        if (playerMovement.IsMoving == true)
        {
            snowmanAnimator.SetBool("isMoving", true);
        } else
        {
            snowmanAnimator.SetBool("isMoving", false);
        }
    }
}
