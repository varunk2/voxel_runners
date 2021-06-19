using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    //private float _objectSpeed;

    void Start()
    {
    }

    void Update()
    {
        if (GameManager._canMove) {
            transform.position -= new Vector3(0f, 0f, (GameManager._worldSpeed * Time.deltaTime));
        }

        if (transform.position.z < PathDestructionPoint._zPosition) {
            //Debug.Log("Destruction point: " + transform.position.z);
            Destroy(gameObject);
        }
    }
}
