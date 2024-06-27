using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{ 
    Vector3 playerPos;
    [SerializeField] Player Follow;


    void Update()
    {
        playerPos = Follow.transform.position;
        playerPos.z = -10f;
             transform.position = playerPos;   
    }
}
