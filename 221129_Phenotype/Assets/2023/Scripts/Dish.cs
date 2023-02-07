using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish : MonoBehaviour
{
    public float touchTime = 0.0f;
    public Material[] mat = new Material[6];

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
            Ing();
        }
    }
    public void Ing()
    {
        if (touchTime < 180)
        {
            gameObject.GetComponent<MeshRenderer>().material = mat[2];
        }
        else if (touchTime < 240)
        {
            gameObject.GetComponent<MeshRenderer>().material = mat[3];
        }
        else
        {
            Clear();
        }
    }
    public void Clear()
    {
        if (touchTime < 300)
        {
            gameObject.GetComponent<MeshRenderer>().material = mat[4];
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = mat[5];
        }
        if (touchTime >= 360)
        {
            Stop();
        }
    }
    public void Stop()
    {
        touchTime = 360.0f;
    }
    //public void Reset()
    //{

    //    if(touchTime >= 500)
    //    {
    //        Stop();
    //    }
    //    else
    //    {
    //        touchTime = 
    //    }

    //}
}
