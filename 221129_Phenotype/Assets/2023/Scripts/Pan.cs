using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour
{
    public float touchTime = 0.0f;
    public Material[] material = new Material[6];

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            touchTime+=Time.deltaTime;
            if (touchTime >= 10.0f)
            {
                Wash();
            }
        }
    }


    public void Wash()
    {
        if (touchTime <= 20.0f)
        {
            Debug.Log("ggg");
            gameObject.GetComponent<MeshRenderer>().material = material[0];
        }
        else if (touchTime <= 30.0f)
        {
            Debug.Log("gg");
            gameObject.GetComponent<MeshRenderer>().material = material[1];
        }
        else
        {
            Ing();
        }
    }
    public void Ing()
    {
        if (touchTime <= 40.0f)
        {
            Debug.Log("gg");
            gameObject.GetComponent<MeshRenderer>().material = material[2];
        }
        else if (touchTime <= 50.0f)
        {
            Debug.Log("ggg");
            gameObject.GetComponent<MeshRenderer>().material = material[3];
        }
        else
        {
            Clear();
        }
    }
    public void Clear()
    {
        if (touchTime <= 60.0f)
        {
            Debug.Log("gggg");
            gameObject.GetComponent<MeshRenderer>().material = material[4];
        }
        else
        {
            Debug.Log("gggggg");
            gameObject.GetComponent<MeshRenderer>().material = material[5];
        }
        if (touchTime >= 70.0f)
        {
            Stop();
        }
    }
    public void Stop()
    {
        touchTime = 70.0f;
    }
}
