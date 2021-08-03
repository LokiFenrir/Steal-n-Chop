using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaptureSheep : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Sheep")
        {

            // Add points or subtract a sheep from UI
            SceneManager.LoadScene("Main_Menu_Scene");

        }

    }//OnCollisionEnter


}// CAPTURE SHEEP
