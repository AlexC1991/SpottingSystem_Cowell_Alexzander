using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

namespace AlexzanderCowell
{


    public class VehicleMovement : MonoBehaviour
    {
        [SerializeField] float vehicleForwardSpeed = 0.5f;
        [SerializeField] float vehicleReverseSpeed = 0.3f;
        [SerializeField] float vehicleTurnSpeed = 0.1f;
        [SerializeField] Transform vehicleToMove;
        [SerializeField] private float yaw = 0.0f;
        [SerializeField] private float pitch = 0.0f;

        private Rigidbody ridgeBody;
       

       
       private void Update()
       {

            float moveMousex = +vehicleTurnSpeed * Input.GetAxis("Mouse X");
            float moveMousey = vehicleTurnSpeed * Input.GetAxis("Mouse X");
            yaw += vehicleTurnSpeed * Input.GetAxis("Mouse X");
            pitch -= vehicleTurnSpeed * Input.GetAxis("Mouse Y");
            


            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.forward * vehicleForwardSpeed;
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.back * vehicleReverseSpeed;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0f, -vehicleTurnSpeed, 0f, Space.Self);

            }

            if (Input.GetKey(KeyCode.D))
            {
                
                transform.Rotate(0f, +vehicleTurnSpeed, 0f, Space.Self);
            }



       }
        

        
    }
}
