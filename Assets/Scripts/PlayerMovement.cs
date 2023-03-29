using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hanzo
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 2.4f;
        public Transform cameraTransform;
        

        private CharacterController characterController;


        // Start is called before the first frame update
        void Start()
        {
            characterController = GetComponent<CharacterController>();
            
        }

     

        // Update is called once per frame
        void Update()
        {
            MovePlayer();
            Look();
        }

        void MovePlayer()
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            move = Vector3.ClampMagnitude(move, 1f);
            move = transform.TransformDirection(move);
            characterController.SimpleMove(move * speed);
        }

        [SerializeField] private float sensitivity = 3f;
        [SerializeField] private float pitch = 0f;
        float MinPitch = -45f;
        float MaxPitch = 20f;


        void Look()
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            transform.Rotate(0, mouseX, 0);
            pitch -= Input.GetAxis("Mouse Y") * sensitivity;
            pitch = Mathf.Clamp(pitch, MinPitch, MaxPitch);

            cameraTransform.localRotation = Quaternion.Euler(pitch,0,0);
        }



    }

}
