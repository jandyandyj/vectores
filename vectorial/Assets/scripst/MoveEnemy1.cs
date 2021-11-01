using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy1 : MonoBehaviour
{

    [SerializeField] private float speedEnemy = 5f;
    [SerializeField] private GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
            MoveTowards();

        

        
    }
    private void MoveTowards()
    {

        Vector3 direction = player.transform.position - transform.position;
        //transform.Translate(speedEnemy * direction.normalized * Time.deltaTime);

        if (direction.magnitude > 2)
        {
            transform.position += speedEnemy * direction.normalized * Time.deltaTime;
        }
    }
   
}
