using UnityEngine;

public class PlayerKick : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float TurnSpeed = 150f;
    public float KickForce = 10f;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float move = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * move * MoveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * turn * TurnSpeed * Time.deltaTime);
        animator.SetBool("Walking", Mathf.Abs(move) > 0.1f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomKick = Random.Range(0, 3);

            animator.SetInteger("KickType", randomKick);
            animator.SetTrigger("Kick");
        }
    }
}