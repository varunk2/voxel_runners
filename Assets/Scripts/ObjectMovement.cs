using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    //private float _objectSpeed;

    void Start()
    {
        /*_objectSpeed = GameManager._worldSpeed;
        Debug.Log(_objectSpeed);*/
    }

    void Update()
    {
        if (GameManager._canMove) {
            transform.position -= new Vector3(0f, 0f, (GameManager._worldSpeed * Time.deltaTime));
            //transform.position -= new Vector3(0f, 0f, (_objectSpeed * Time.deltaTime));
        }

        if (transform.position.z < PathDestructionPoint._zPosition) {
            Destroy(gameObject);
        }
    }
}
