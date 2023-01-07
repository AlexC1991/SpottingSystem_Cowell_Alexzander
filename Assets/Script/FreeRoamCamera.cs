using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AlexzanderCowell
{


    public class FreeRoamCamera : MonoBehaviour
    {

        [Header("Cameras")]
        [SerializeField] GameObject playerCamera;
        [SerializeField] GameObject freeRoamCamera;

        private float cameraSpeed;
        private float cameraTurnSpeed = 2f;
        private bool freeRoamCameraOnOrOff;
        private bool playerCameraOnOrOff;
        

        private void Start()
        {
            freeRoamCameraOnOrOff = false;
            playerCameraOnOrOff = true;
            playerCamera.GetComponent<AudioListener>().enabled = true;
            freeRoamCamera.GetComponent<AudioListener>().enabled = false;
        }

        void Update()
        {
            freeRoamCamera.transform.Translate(0, 0, cameraSpeed * Time.deltaTime, Space.Self);
            
            if (freeRoamCameraOnOrOff == true)
            {
                playerCamera.SetActive(false);
                freeRoamCamera.SetActive(true);
                playerCamera.GetComponent<AudioListener>().enabled = false;
                freeRoamCamera.GetComponent<AudioListener>().enabled = true;

                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    cameraSpeed =+ 20;
                }
                if (Input.GetKeyUp(KeyCode.UpArrow))
                {
                    cameraSpeed = 0;
                }


                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    cameraSpeed -= 20;
                }
                
                if (Input.GetKeyUp(KeyCode.DownArrow))
                {
                    cameraSpeed = 0;
                }

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    freeRoamCamera.transform.Rotate(0f, -cameraTurnSpeed, 0f);
                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    freeRoamCamera.transform.Rotate(0f, +cameraTurnSpeed, 0f, Space.Self);
                }
            }

            if (playerCameraOnOrOff == true)
            {
                playerCamera.SetActive(true);
                freeRoamCamera.SetActive(false);
                playerCamera.GetComponent<AudioListener>().enabled = true;
                freeRoamCamera.GetComponent<AudioListener>().enabled = false;
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                freeRoamCameraOnOrOff = true;
                playerCameraOnOrOff = false;
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                freeRoamCameraOnOrOff = false;
                playerCameraOnOrOff = true;
            }

        }
    }
}
