using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CMvcam : MonoBehaviour
{
    CinemachineVirtualCamera CCVC;
    // Start is called before the first frame update
    void Start()
    {
        CCVC = this.gameObject.GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
