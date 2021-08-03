using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Vars

    public float _moveSpeed = 300f;
    Rigidbody _rb;

    public LayerMask _ground;
    public float _jumpForce = 10f;
    float _dropForce = 8f;
    CapsuleCollider _cap;

    bool _isGrounded()
    {

        return Physics.CheckCapsule(_cap.bounds.center, new Vector3(_cap.bounds.center.x, _cap.bounds.min.y, _cap.bounds.center.z),
            _cap.radius * .9f, _ground);

    }//_isGrounded


    //Funcs

    void Awake()
    {

        _rb = GetComponent<Rigidbody>();

        _cap = GetComponent<CapsuleCollider>();

    }//Awake


    void Update()
    {

        _rb.velocity = transform.forward * _moveSpeed * Time.deltaTime;

        if (!_isGrounded())
            transform.position = new Vector3(0, -200f * Time.deltaTime, 0);


    }//Update

    
    public void RotateLeft()
    {

        transform.Rotate(25f, 0, 0);

    }//RotateLeft


    public void RotateRight()
    {

        transform.Rotate(-25f, 0, 0);

    }//RotateRight


    public void CaptureRotateBack()
    {

        transform.Rotate(-90, 0, 0);

    }//CaptureRotateBack


    public void Jump()
    {

        if(_isGrounded())
         _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);

    }//Jump

}// PLAYER CONTROLLER
