using System.Collections;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static event Action OnCubeSpawned = delegate { };

    private CubeRespawn[] spawner;
    private int spawnerIndex;
    private CubeRespawn CurrentSpawn;

    private void Awake()
    {
       spawner = FindObjectsOfType<CubeRespawn>();
    }
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                if(MovingCube.CurrentCube != null)
                    MovingCube.CurrentCube.Stop();
                spawnerIndex = spawnerIndex == 0 ? 1 : 0;
                CurrentSpawn = spawner[spawnerIndex];

                CurrentSpawn.SpawnCube();
                OnCubeSpawned();
            }
        }
    }
}
