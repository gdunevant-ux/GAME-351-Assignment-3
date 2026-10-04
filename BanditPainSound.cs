using UnityEngine;

public class BanditPainSound : MonoBehaviour
{
    private AudioSource painSound;

    void Start()
    {
        painSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            painSound.Play();
        }
    }
}