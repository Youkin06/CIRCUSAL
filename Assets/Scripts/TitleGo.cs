using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleGo : MonoBehaviour
{
    public PlayerController PC;
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        /*
        if(PC.GameOver == true)
        {
            this.gameObject.SetActive(true);
        }
        */
    }

    public void OnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
