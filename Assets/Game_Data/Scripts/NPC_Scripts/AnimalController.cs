using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimalController : MonoBehaviour
{

    // Vars

    NavMeshAgent _agent;

    Animator _anim;

    public GameObject _player;

    public float _enemyDistRun = 4.0f;

    // Funcs

    void Start()
    {

        _agent = GetComponent<NavMeshAgent>();
        _anim = GetComponent<Animator>();

        _player = GameObject.FindGameObjectWithTag("Player");

    }//Start


    void Update()
    {

        float _dis = Vector3.Distance(transform.position, _player.transform.position);

        if (_dis < _enemyDistRun)
        {

            Vector3 dirToPlayer = transform.position - _player.transform.position;

            Vector3 _newPos = transform.position + dirToPlayer;

            _agent.SetDestination(_newPos);
            _anim.SetBool("isWalking", true);

        }
        else
            _anim.SetBool("isWalking", false);


    }//Update


}// ANIMAL CONTROLLER
