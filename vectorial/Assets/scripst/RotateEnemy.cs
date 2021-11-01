using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemy : MonoBehaviour
{
    [SerializeField] private GameObject playerR;
    [SerializeField] private float lerpRotate = 1f;
    // Start is called before the first frame update
    void Start()
    {
        playerR = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        LookAtLerp(playerR);
    }
    private void LookAtLerp(GameObject lookObject)
        {
            Vector3 direction = lookObject.transform.position - transform.position;
            Quaternion newQuaternion = Quaternion.LookRotation(direction);
           // transform.rotation = newQuaternion;
        transform.rotation = Quaternion.Lerp(transform.rotation, newQuaternion, lerpRotate * Time.deltaTime);
        }
    } 

