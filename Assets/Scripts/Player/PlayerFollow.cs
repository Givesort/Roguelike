using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform cameraTransform;
    public Transform playerTransform;

    [SerializeField]
    private Vector3 offset = new Vector3(0, 0, -1);

    private void Update()
    {
        cameraTransform.position = playerTransform.position + offset;
    }
}
