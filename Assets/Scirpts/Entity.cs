using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public string EntityName;
    public bool PlayOnAwake = true;
    public bool Disabled = false;


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

    public void DisabledWhenTouchedOnce()
    {
        if (!Disabled)
        {
           Disabled = true;
        }
    }
}
