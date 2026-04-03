using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveCam : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        transform.position =cameraPosition.position;
    }
}
