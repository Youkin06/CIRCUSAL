using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxS : MonoBehaviour
{
    public bool destroy_b = false;
    GameObject Box_s_per;
    Vector3 pos;

    private void Start() {
        Box_s_per = (GameObject)Resources.Load("Box_s_per"); 
        pos = this.transform.position;   
    }
    void Update()
    {
        if(destroy_b == true)
        {
            Instantiate(Box_s_per, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
