using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreGameStartLoad : MonoBehaviour
{
    public GameObject TitleGo;
    public GameObject tap_GameOVer_obj;

    // Start is called before the first frame update
    void Start()
    {
        TitleGo = GameObject.FindWithTag("TitleGo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameLoad()
    {
        TitleGo.SetActive(true);
        tap_GameOVer_obj.SetActive(true);
    }
}
