using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathGenerationController : MonoBehaviour
{
    [SerializeField] private GameObject pathPiece;
    [SerializeField] private GameObject[] pathPieces;
    [SerializeField] private Transform thresholdPoint;
    public float tileZAxis;

    void Update()
    {
        if (transform.position.z < thresholdPoint.position.z) {
            // copy the pathPiece and move forward
            //Instantiate(pathPiece, transform.position, transform.rotation);
            //transform.position += new Vector3(0f, 0f, tileZAxis);

            // Random Path Generation
            int selectPiece = Random.Range(0, pathPieces.Length);
            Instantiate(pathPieces[selectPiece], transform.position, transform.rotation);
            transform.position += new Vector3(0f, 0f, tileZAxis);
        }
    }
}
