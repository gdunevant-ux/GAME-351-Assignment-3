using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip footstep;

    private float timer;

    void Update()
    {
        float move = Input.GetAxis("Vertical");

        if (Mathf.Abs(move) > 0.1f)
        {
            timer -= Time.deltaTime;

            if (timer <= 0 && !audioSource.isPlaying)
            {
                audioSource.PlayOneShot(footstep);
                timer = 0.8f;
            }
        }
        else
        {
            timer = 0;
        }
    }
}