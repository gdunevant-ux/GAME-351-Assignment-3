using UnityEngine;

public class ExplosionSound : MonoBehaviour
{
    private AudioSource explosion;

    void Start()
    {
        explosion = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            explosion.Play();
        }
    }
}