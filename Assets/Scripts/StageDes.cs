using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDes : MonoBehaviour
{
    public float time;
    public GameObject GM_obj;
    public GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        GM_obj = GameObject.FindWithTag("GM");
        GM = GM_obj.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(GM.GameStart_GM == true)
        {
            time += Time.deltaTime;
            if(time >= 40)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
