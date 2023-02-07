using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phon : MonoBehaviour
{
    
    // Start is called before the first frame update
    int random;
    public Material[] mater = new Material[6];

    private void Start()
    {
        random = Random.Range(60, 180);
        Invoke("RandomWaitAndPlay", random);
        
    }
    void RandomWaitAndPlay()
    {

        gameObject.GetComponent<MeshRenderer>().material = mater[0];
        Debug.Log("ÀüÈ­");
    }
}

