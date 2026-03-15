using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool GameStart;
    //public bool Box_broken = false;
    public bool TimeLimit_b;
    public bool GameOver;

    public int tap_count;

    public float speed;
    public float downSpeed;
    public float HP;
    public float TimeLimit_f;

    public GameObject box_obj;

    /*SCRIPTS*/
    BoxS BS;
    //public int coin_num;
    public bool Start_ = false;
    GameObject player_per;
    Vector3 pos;
    public bool SpeedUp_b;
    public GameManager GM;



    // Start is called before the first frame update
    void Start()
    {
        GameStart = false;
        HP = this.gameObject.transform.localScale.x;
        player_per = (GameObject)Resources.Load("Player_per");
        speed = 4;
        downSpeed = 3;
        SpeedUp_b = false;
        //pos = this.transform.position;
        GameObject GM_obj = GameObject.FindWithTag("GM");
        GM = GM_obj.GetComponent<GameManager>();
        GameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.transform.position;

        if(GameStart == false)
        {
            /*
            if(Input.GetMouseButtonDown(0))
            {
                GameStart = true;
                Start_ = true;
                downSpeed = -3;
                tap_count = 1;
               
            }
            */
        }else if(GameStart == true)
        {
            if(SpeedUp_b == false)
            {
                speed = 4;
            }else if(SpeedUp_b == true){
                speed = 7;
            }
            //Start_ = false;
            this.transform.position += new Vector3(speed, downSpeed,0) * Time.deltaTime;
            HP -= Time.deltaTime / 5;

            this.transform.localScale = new Vector3(HP,HP,HP);
            /*
            for(float i = 1.5f; i > 0; i -= 0.2f)
            {
                this.transform.localScale = new Vector3(i,i,i);
                //yield return new WaitForSeconds(0.2f);
            }
            */
            //StartCoroutine("ScaleDown");

            
            

            if(tap_count == 1)
            {
                if(TimeLimit_b == false)
                {
                    if(Input.GetMouseButtonDown(0))
                    {
                        if(SpeedUp_b == false)
                        {
                            downSpeed = 3;
                            tap_count = 2;
                        }else if(SpeedUp_b == true){
                            downSpeed = 5;
                            tap_count = 2;
                        }
    

                    }
                }else if(TimeLimit_b == true)
                {

                    downSpeed = -0.3f;
                    TimeLimit_f += Time.deltaTime;
                    float nowSpeed = downSpeed;

                    if(TimeLimit_f <= 0.2f)
                    {
                        if(Input.GetMouseButtonDown(0))
                        {
                            if(SpeedUp_b == false)
                            {
                            TimeLimit_b = false;
                            HP = 1.5f;
                            TimeLimit_f = 0;
                            BS.destroy_b = true;
                            downSpeed = 10;
                            tap_count = 2; 
                            GM.score += 2;
                            }else if(SpeedUp_b == true){
                            TimeLimit_b = false;
                            HP = 1.5f;
                            TimeLimit_f = 0;
                            BS.destroy_b = true;
                            downSpeed = 11;
                            tap_count = 2;
                            GM.score += 2;

                            }
                        }
                    }else if(TimeLimit_f > 0.2f)
                    {
                        if(Input.GetMouseButtonDown(0))
                        {
                            //BS.destroy_b = false;
                            if(SpeedUp_b == true)
                            {
                            TimeLimit_b = false;
                            downSpeed = 3;
                            tap_count = 2;
                            TimeLimit_f = 0;
                            }else if(SpeedUp_b == false){
                            TimeLimit_b = false;
                            downSpeed = 5;
                            tap_count = 2;
                            TimeLimit_f = 0;
                            }
                        }
                        
                    }
                }
                /*
                if(Input.GetMouseButtonDown(0))
                {
                    if(TimeLimit_b == false)
                    {
                        downSpeed = 3;
                    //this.transform.position += new Vector3(0,-downSpeed,0);
                    tap_count = 2;
                    }else if(TimeLimit_b == true)
                    {
                        TimeLimit_f += Time.deltaTime;
                        float nowSpeed = downSpeed;
                        if(TimeLimit_f <= 0.3f)
                        {

                        }
                    }
                */
                    //downSpeed = 3;
                    //this.transform.position += new Vector3(0,-downSpeed,0);
                    //tap_count = 2;
                    /*
                    if(TimeLimit_b == true)
                    {
                        TimeLimit_f += Time.deltaTime;

                        float nowSpeed = downSpeed;
                        
                        if(TimeLimit_f <= 0.3f)
                        {
                            TimeLimit_b = false;
                            HP = 1.5f;
                            TimeLimit_f = 0;

                            
                            //Box_broken = true;
                            BS.destroy_b = true;
                        }else if(TimeLimit_f > 0.3f){
                            BS.destroy_b = false;
                            TimeLimit_f = 0;
                        }
                        
                    }
                    */
                
                
            }else if(tap_count == 2)
            {
                if(TimeLimit_b == false)
                {
                    if(Input.GetMouseButtonDown(0))
                    {
                        if(SpeedUp_b == false)
                        {
                        downSpeed = -3;
                        tap_count = 1;
                        }else if(SpeedUp_b == true){
                        downSpeed = -5;
                        tap_count = 1;
                        }
                    }
                }else if(TimeLimit_b == true)
                {
                    downSpeed = 0.3f;
                    TimeLimit_f += Time.deltaTime;
                    float nowSpeed = downSpeed;

                    if(TimeLimit_f <= 0.2f)
                    {
                        if(Input.GetMouseButtonDown(0))
                        {
                            if(SpeedUp_b == false)
                            {
                            TimeLimit_b = false;
                            HP = 1.5f;
                            TimeLimit_f = 0;
                            tap_count = 1;
                            downSpeed = -10;
                            BS.destroy_b = true; 
                            GM.score += 2;
                            }else if(SpeedUp_b == true){
                            TimeLimit_b = false;
                            HP = 1.5f;
                            TimeLimit_f = 0;
                            tap_count = 1;
                            downSpeed = -11;
                            BS.destroy_b = true; 
                            GM.score += 2;
                            }
                        }
                    }else if(TimeLimit_f > 0.2f)
                    {
                        if(Input.GetMouseButtonDown(0))
                        {
                            //BS.destroy_b = false;
                            if(SpeedUp_b == false)
                            {
                            TimeLimit_b = false;
                            tap_count = 1;
                            downSpeed = -3;
                            TimeLimit_f = 0;
                            }else if(SpeedUp_b == true){
                                TimeLimit_b = false;
                            tap_count = 1;
                            downSpeed = -5;
                            TimeLimit_f = 0;
                            }
                        }
                        
                    }
                }
                
            }
            if(HP < 0)
            {
                speed = 0;
                downSpeed = 0;
                HP = 0;
                Instantiate(player_per, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
                this.gameObject.SetActive(false);
                GameStart = false;
                GameOver = true;
            }

        }

            
        
        /*
        if(HP <= 0)
        {
            speed = 0;
            downSpeed = 0;
            HP = 0;
            Instantiate(player_per, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
            
        }
        */

        
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Box_s")
        {
            TimeLimit_b = true;
            box_obj = other.gameObject;
            BS = box_obj.GetComponent<BoxS>();
        }
        if(other.gameObject.tag == "DesBox")
        {
            //Destroy(this.gameObject);
            if(GameStart == true)
            {
            Instantiate(player_per, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
            }
            this.gameObject.SetActive(false);
            GameStart = false;
            GameOver = true;
        }
        if(other.gameObject.tag == "Coin")
        {
            GM.coin_num += 1;
            
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "SpeedUpBox")
        {
            Debug.Log("SpeedUp");
            SpeedUp_b = true;

        }
        if(other.gameObject.tag == "SpeedDownBox")
        {
            Debug.Log("SpeedDown");
            SpeedUp_b = false;
        }
        if(other.gameObject.tag == "scoreAlpha")
        {
            GM.scoreAlpha_b = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "scoreAlpha")
        {
            GM.scoreAlpha_b = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Box_s")
        {
            //Destroy(BS);
        }
    }

   
}
