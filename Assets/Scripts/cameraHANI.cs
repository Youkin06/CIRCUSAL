using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraHANI : MonoBehaviour
{
    public GameObject cam_v;
    Transform cam_v_trans;

    // Start is called before the first frame update
    void Start()
    {
        cam_v = GameObject.FindWithTag("CMvcam");
        cam_v_trans = cam_v.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(cam_v_trans.position.x, 0, -10);
    }
}
