using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeLineMovementController : MonoBehaviour
{
    [SerializeField] private Transform _disappearPoint;
    [SerializeField] private BoxCollider _boxCollider;
    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager._canMove) {
            transform.position -= new Vector3(0f, 0f, (GameManager._worldSpeed * Time.deltaTime));
        }

        if (transform.position.z < _disappearPoint.position.z) {
            transform.position += new Vector3(0f, 0f, _boxCollider.bounds.size.z * 2f);
        }
    }
}
