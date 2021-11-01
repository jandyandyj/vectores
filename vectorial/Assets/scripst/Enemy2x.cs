using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2x : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject player;
    [SerializeField] private float lerpRotate = 1f;
    
    enum Modes {lookat =1 , follow=2 , fail=3 };
    [SerializeField] private Modes modo;

   // Start is called before the first frame update
   void Start()
    {
        player = GameObject.Find("Player");

       
    }

    // Update is called once per frame
    void Update()
    {
        switch (modo)
        {
            case Modes.follow:
                Debug.Log("Persecuta");
                Vector3 direction = player.transform.position - transform.position;
                if (direction.magnitude > 2)
                {
                    transform.position += speed * direction.normalized * Time.deltaTime;
                }
                break;

            case Modes.lookat:
                Debug.Log("Fichon");
                LookAtlerp(player);
                break;

            case Modes.fail:
                Debug.Log("fail");
                break;

        }

    }
    private void LookAtlerp(GameObject lookObject)
    {
        Vector3 direction = lookObject.transform.position - transform.position;
        Quaternion newQuaternion = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(newQuaternion , transform.rotation, lerpRotate * Time.deltaTime);
    }
}
