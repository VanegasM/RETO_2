using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitCounter : MonoBehaviour
{
    public GameObject Door;
   // public int tagScene = 0;
    void Update()
    {
        if (gameObject.transform.childCount == 0)
        {
            gameObject.SetActive(false);
            // SceneManager.LoadScene(tagScene);
            Destroy(Door); 

        }
    }
    

}
