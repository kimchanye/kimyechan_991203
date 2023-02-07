using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public Image start;
    public Image backgroundImg;
    private float transition = 0.0f;





    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("h");
            backgroundImg.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, transition);
            start.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, transition);

        }
        
        
    }
  

}
