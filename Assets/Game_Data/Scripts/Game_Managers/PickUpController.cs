using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    // Vars

    PlayerController _player;

    bool _rangerPower;

    float _powerTimer;
    public float _maxPowerTime;

    EconomyController _economy;

    // Funcs

    void Awake()
    {

        _player = FindObjectOfType<PlayerController>();

        _economy = FindObjectOfType<EconomyController>();

    }//Awake


    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "My Ford Bakkie")
        {

            //Increase players speed.
            _player._moveSpeed = 450f;
            _rangerPower = true;
            _powerTimer = _maxPowerTime;

        }

        if(other.gameObject.tag == "BraaiBucks")
        {

            // Add Coins;
            _economy.BraaiBucksAdded();

        }

    }//OnTriggerEnter


    private void Update()
    {

        if (_rangerPower)
        {

            if(_powerTimer <= 0)
            {

                _player._moveSpeed = 300f;
                _rangerPower = false;

            }
            else
            {

                _powerTimer -= Time.deltaTime;

            }

        }

    }//Update


}// PICK UP CONTROLLER
