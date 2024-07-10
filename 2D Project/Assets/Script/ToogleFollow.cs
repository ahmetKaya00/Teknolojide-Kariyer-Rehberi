using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToogleFollow : MonoBehaviour
{
    public CinemachineVirtualCamera VirtualCamera;

    public GameObject player1, player2;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(VirtualCamera.Follow = player1.transform)
            {
                VirtualCamera.Follow = player2.transform;
            }
            else if (VirtualCamera.Follow = player2.transform)
            {
                VirtualCamera.Follow = player1.transform;
            }
        }

    }
}
