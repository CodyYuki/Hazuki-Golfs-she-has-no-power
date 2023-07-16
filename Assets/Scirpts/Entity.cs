using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public string EntityName;
    public bool PlayOnAwake = true;


    private void Awake()
    {
        if(!PlayOnAwake)
        {
            Animator animator = GetComponent<Animator>();
            if (animator != null)
            {
                animator.speed = 0;
            }
        }
    }

    public void PlayAnimation(float speed = 1)
    {
        Animator animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.speed = speed;
        }
    }
}
