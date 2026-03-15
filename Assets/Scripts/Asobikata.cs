using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asobikata : MonoBehaviour
{
    public GameObject Asobikata_obj;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {;
        anim = Asobikata_obj.GetComponent<Animator>();
    }

    public void OnClick()
    {
        Asobikata_obj.SetActive(true);
    }

    public void OnClickFinish()
    {
        anim.SetBool("asobikata", true);
    }

    public void SetActive_()
    {
        this.gameObject.SetActive(false);
    }
}
