using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap : MonoBehaviour
{
    public Animator anim;
    public GameObject player_obj;
    public PlayerController player_sc;

    // Start is called before the first frame update
    void Start()
    {
        player_obj = GameObject.FindWithTag("Player");
        player_sc = player_obj.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player_sc.GameStart == true)
        {
            anim.SetBool("GameStart", true);
        }
    }
    
}
