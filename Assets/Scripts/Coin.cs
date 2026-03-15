using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameObject Coin_per;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        Coin_per = (GameObject)Resources.Load("Coin_per");
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player")
        {
            Instantiate(Coin_per, new Vector3(pos.x, pos.y, pos.z ), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
