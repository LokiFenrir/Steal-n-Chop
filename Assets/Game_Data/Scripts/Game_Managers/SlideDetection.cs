using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDetection : MonoBehaviour
{

    // Vars

    public PlayerController player;

    Vector2 startPos;

    public int pixelDistToDetect = 20;

    bool fingerDown;


    // Funcs

    void Update()
    {
        
        if(fingerDown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {

            startPos = Input.touches[0].position;
            fingerDown = true;

        }


        if (fingerDown)
        {

            if(Input.touches[0].position.y >= startPos.y + pixelDistToDetect)
            {

                // Swiped up
                fingerDown = false;
                Debug.Log("Swipe up");

            }
            else if(Input.touches[0].position.x <= startPos.x - pixelDistToDetect)
            {

                fingerDown = false;
                player.RotateRight();

            }
            else if(Input.touches[0].position.x >= startPos.x + pixelDistToDetect)
            {

                fingerDown = false;
                Debug.Log("Swipe Right");
                player.RotateLeft();

            }

        }

        //Did we realse finger
        if(fingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
        {

            fingerDown = false;

        }

      /*  //Testing
        if(fingerDown == false && Input.GetMouseButtonDown(0))
        {

            startPos = Input.mousePosition;
            fingerDown = true;

        }


        if (fingerDown)
        {

            if (Input.mousePosition.y >= startPos.y + pixelDistToDetect)
            {

                // Swiped up
                fingerDown = false;
                player.GetComponent<Animator>().SetTrigger("Jump");
                player.Jump();

            }
            else if (Input.mousePosition.x <= startPos.x - pixelDistToDetect)
            {

                fingerDown = false;
                player.Rotate();

            }
            else if (Input.mousePosition.x >= startPos.x + pixelDistToDetect)
            {

                fingerDown = false;
                player.Rotate();

            }
            else if(Input.mousePosition.y <= startPos.y - pixelDistToDetect)
            {

                fingerDown = false;
                player.GetComponent<Animator>().SetTrigger("Capture");

            }

        }


        if (fingerDown && Input.GetMouseButtonUp(0))
            fingerDown = false;
        */

    }//Update

}// SLIDE DETECTION
