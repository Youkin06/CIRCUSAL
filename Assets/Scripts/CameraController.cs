using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player_obj;
    Transform player_trans;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        /*
        player_obj = GameObject.FindWithTag("Player");
        player_trans = player_obj.GetComponent<Transform>();
        pos = this.transform.position;
        */

    }

    // Update is called once per frame
    void Update()
    {
        player_obj = GameObject.FindWithTag("Player");
        player_trans = player_obj.GetComponent<Transform>();
        pos = this.transform.position;

        this.transform.position = new Vector3(player_trans.position.x, 0, player_trans.position.z-100);

        if(player_trans.position.y >= 10)
        {
            if(pos.y < 15)
            {
                transform.Translate(0,20,0);
            }else if(pos.y >= 15)
            {
                pos.y = 15;
            }

        }
    }
}
