using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asobikata_obj : MonoBehaviour
{
    GameObject asobikata_obj;
    // Start is called before the first frame update
    void Start()
    {
        asobikata_obj = GameObject.FindWithTag("Asobikata");
        asobikata_obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickFinish()
    {
        asobikata_obj.SetActive(false);
    }

    
}
