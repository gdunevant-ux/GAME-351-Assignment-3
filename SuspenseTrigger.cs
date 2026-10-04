using UnityEngine;

public class SuspenseTrigger : MonoBehaviour
{
    public MusicManager musicManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            musicManager.PlaySuspense();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            musicManager.PlayDefault();
        }
    }
}