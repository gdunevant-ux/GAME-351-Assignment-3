using UnityEngine;

public class PlayerKick : MonoBehaviour
{
    public float KickForce = 10f;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomKick = Random.Range(0, 3);

            animator.SetInteger("KickType", randomKick);

            animator.SetTrigger("Kick");
        }
    }
}