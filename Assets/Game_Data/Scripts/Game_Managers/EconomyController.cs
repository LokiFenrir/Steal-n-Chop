using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EconomyController : MonoBehaviour
{
    // Vars

    int _braaiBucks;

    public Text _buckTxt;

    // Funcs

    void Awake()
    {

        _braaiBucks = PlayerPrefs.GetInt("BraaiBucks");

        _buckTxt = GameObject.Find("BraaiBucks_Text").GetComponent<Text>();

        Debug.Log(_braaiBucks);

    }//Awake


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
            BraaiBucksAdded();

        _buckTxt.text = _braaiBucks + " BraaiBucks";

    }


    public void BraaiBucksAdded()
    {

        int _amount = Random.Range(10, 50);
        _braaiBucks += _amount;
        Debug.Log("BraaiBucks added " + _amount.ToString());

        PlayerPrefs.SetInt("BraaiBucks", _braaiBucks);

    }//BraaiBucksAdded


}// ECONOMY CONTROLLER
