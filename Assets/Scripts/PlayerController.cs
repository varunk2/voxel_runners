using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private Transform _modelHolder;
    
    private Rigidbody _rigidbody;
    
    public float moveSpeed;
    public float jumpForce;
    public LayerMask whatIsGround;
    public bool onGround;

    public Animator animator;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (_gameManager.canMove) {
            onGround = Physics.OverlapSphere(_modelHolder.position, 0.2f, whatIsGround).Length > 0;

            if (onGround) {
                if (Input.GetMouseButtonDown(0)) {
                    // Make the player jump
                    _rigidbody.velocity = new Vector3(0f, jumpForce, 0f);
                }                
            }
        }

        // Control Animations
        animator.SetBool("walking", _gameManager.canMove);
        animator.SetBool("onGround", onGround);
    }

    public void OnTriggerEnter(Collider other) {
        if (other.tag == "Hazards") {
            _gameManager.HitHazard();

            ModifyPlayerPhysics();
        }
    }

    private void ModifyPlayerPhysics() {
        // _rigidbody.isKinematic = false;

        _rigidbody.constraints = RigidbodyConstraints.None;

        float xAxis = UnityEngine.Random.Range(GameManager._worldSpeed / 2f, -GameManager._worldSpeed / 2f);
        float yAxis = 2.5f;
        float zAxis = -GameManager._worldSpeed / 2f;

        _rigidbody.velocity = new Vector3(xAxis, yAxis, zAxis);
    }
}
