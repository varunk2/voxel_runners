using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool canMove;
    static public bool _canMove;

    public float worldSpeed;
    static public float _worldSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        _canMove = canMove;
        _worldSpeed = worldSpeed;
    }
}
