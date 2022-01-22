using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 0;
    private Rigidbody rigidbody;

    private SceneController sceneController;
    private Vector3 mousePos;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        sceneController = GameObject.FindObjectOfType<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        // var delta:Vector3 = Input.mousePosition - mousePos;
        // mousePos = Input.mousePosition;
        // delta = delta * 10 * Time.deltaTime;
        // transform.Rotate(eulers:new Vector3(x:0,y:delta.x,z:0));

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        bool jump = Input.GetButtonDown("Jump");
        Vector3 movement = new Vector3(x:horizontal,y:0,z:vertical);
        movement = movement * movementSpeed;
        rigidbody.AddForce(movement);

        if(transform.position.y < -10)
        {
            if (sceneController != null)
            {
                sceneController.ReloadScene();
            }
            else
            {
                Debug.LogWarning(message:"Add Scene Controller.");
            }
            
        }
    }
}
