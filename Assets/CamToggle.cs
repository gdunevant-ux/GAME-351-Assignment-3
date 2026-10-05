using UnityEngine;
using Cinemachine;

public class CamToggle : MonoBehaviour
{
    public CinemachineVirtualCamera thirdPersonCam;
    public CinemachineVirtualCamera firstPersonCam;

    void Start()
    {
        thirdPersonCam.Priority = 10;
        firstPersonCam.Priority = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (thirdPersonCam.Priority > firstPersonCam.Priority)
            {
                thirdPersonCam.Priority = 0;
                firstPersonCam.Priority = 10;
            }
            else
            {
                thirdPersonCam.Priority = 10;
                firstPersonCam.Priority = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            thirdPersonCam.Priority = 10;
            firstPersonCam.Priority = 0;
        }
    }
}