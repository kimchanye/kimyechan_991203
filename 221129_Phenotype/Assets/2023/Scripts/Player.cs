using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //float hAxis;
    //float vAxis;
    //Vector3 moveVec;
    //public float speed = 5.0f;




    public GameObject lifePosition = null;
    


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Book"))
        {
            transform.position = lifePosition.transform.position;
        }
    }

    //void Update()
    //{



    //    hAxis = Input.GetAxisRaw("Horizontal");
    //    vAxis = Input.GetAxisRaw("Vertical");

    //    moveVec = new Vector3(hAxis, 0, vAxis).normalized;
    //    transform.position += moveVec * speed * Time.deltaTime;
    //}
}
