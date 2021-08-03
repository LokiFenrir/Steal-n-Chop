using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugMenuController : MonoBehaviour
{

    // Vars

    public float _playerSpeed;

    [SerializeField]
    InputField _playerSpeedInput;

    
    public GameObject _powerUp;

    public GameObject _spawnPoint;

    // Funcs

    void Start()
    {

        var ps = new InputField.SubmitEvent();
        ps.AddListener(PlayerSpeed);
        _playerSpeedInput.onEndEdit = ps;

    }// Start


    void PlayerSpeed(string num)
    {

        _playerSpeed = float.Parse(_playerSpeedInput.text);

    }//PlayerSpeed


    public void PowerUp()
    {

        Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        Instantiate(_powerUp, _spawnPoint.transform.position, Quaternion.identity);

    }//PowerUp


}// DEBUG MENU CONTROLLER


