using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathDestructionPoint : MonoBehaviour
{
    static public float _zPosition;

    void Start()
    {
        InitializeZPosition();
    }

    void Update()
    {
        InitializeZPosition();
    }

    void InitializeZPosition() {
        _zPosition = transform.position.z;
    }
}
