using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedPlayer = 5f;
    [SerializeField] private float rotateSpeedPlayer = 20f;
    //[SerializeField] private float mouseAxis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        // RotatePlayer();
        RotatePlaybetter();
    }
    private void MovePlayer()
    {
      //  float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        transform.Translate(speedPlayer * new Vector3(0, 0, vAxis) * Time.deltaTime);
    }
    /*private void RotatePlayer()
    {
        mouseAxis += Input.GetAxis("Mouse X");
        Quaternion newRotation = Quaternion.Euler(0, mouseAxis, 0);
        transform.rotation = newRotation;
    */

    private void RotatePlaybetter()
    {
        float hAxis = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, hAxis * Time.deltaTime * rotateSpeedPlayer);
    }
    
    
}

