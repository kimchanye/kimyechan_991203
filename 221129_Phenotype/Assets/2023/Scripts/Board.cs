using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public float touchTime = 0.0f;
    public Material[] mat = new Material[2];
    
    public void Start()
    {
        
    }
    

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            touchTime++;
            Wash();
        }
    }
    public void Wash()
    {

        if (touchTime < 60)
        {
            gameObject.GetComponent<MeshRenderer>().material = mat[0];
        }
        else if (touchTime < 120)
        {
            gameObject.GetComponent<MeshRenderer>().material = mat[1];
        }
        else
        {
            Stop();
        }
    }
    public void Stop()
    {
        touchTime = 120.0f;
    }
}
