using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    // Vars

    [SerializeField]
    Transform _player;

    [SerializeField]
    Vector3 _camOffset;

    [Range(0.01f, 1f)]
    public float _smoothness = 0.5f;
    
    [SerializeField]
    bool _lookAtPlayer = false;


    // Funcs

    void Start()
    {

        _player = GameObject.Find("Player").transform;
        _camOffset = transform.position - _player.position;

    }//Start


    void LateUpdate()
    {

        Vector3 newPos = _player.position + _camOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, _smoothness);

        if (_lookAtPlayer)
            transform.LookAt(_player);

    }//LateUpdate

}// CAMERA CONTROLLER
