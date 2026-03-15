using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    public GameObject[] stage;
    public GameObject[] player_obj;
    public bool stageMake = false;
    //public float stageMakePos;
    int num;
    public float nowSetPos;
    public Transform player_trans;
    public PlayerController PC;
    float player_x;
    public float NUM;
    public GameObject HighSANKAKU;
    public GameObject LowSANKAKU;
    public GameObject score_obj;
    public TextMeshProUGUI score_txt;
    public int score;
    public float tall;
    public Vector3 pos_player;
    public Animator anim_score;
    public bool scoreAlpha_b;
    public GameObject Kurakusuru;
    public Animator Kurakusuru_anim;
    public GameObject TitleGo_obj;
    public GameObject tap_GameOVer_obj;

    //今回のスコアと最大スコアのあれこれ
    public int score_now = 0;
    public int score_best;

    
    public GameObject score_best_obj;
    public GameObject score_bestTitle_obj;
    public TextMeshProUGUI score_best_txt;
    public Animator anim_scoreBest;
    public Animator anim_scoreBestTitle;

    public GameObject KurakusuruStart;
    public Animator KurakusuruStart_anim;
    public GameObject TITLE_obj;
    public Animator TITLE_anim;
    //コイン
    public int coin_num;
    public GameObject coinNum_obj;
    public TextMeshProUGUI coinNum_txt;
    
    //スキン切り替え全般
    public int skin_num;
    public int skin_num_max;
    public int[] skinGet;
    public GameObject[] skin_sprite;
    public GameObject[] Lock_obj;
    public GameObject[] skinBuy;

    public GameObject GameStart_obj;

    //Camera
    CinemachineVirtualCamera CCVC;
    public GameObject CVC_cam;

    public GameObject tap_obj;
    Animator tap_anim;

    public GameObject skinSelect_obj;
    public Animator skinSelect_anim;

    public bool GameStart_GM;

    public GameObject Hatena_obj;
    public Animator Hatena_anim;

    // Start is called before the first frame update
    void Start()
    {
        //stageMake = true;
        //player_obj = GameObject.FindWithTag("Player");
        //PC = player_obj.GetComponent<PlayerController>();
        //player_trans = player_obj.GetComponent<Transform>();
        //pos_player = player_obj.transform.position;
        score = 0;
        score_obj = GameObject.FindWithTag("score");
        score_txt = score_obj.GetComponent<TextMeshProUGUI>();
        anim_score = score_obj.GetComponent<Animator>();
        score_obj.SetActive(false);
        Kurakusuru = GameObject.FindWithTag("daruk");
        Kurakusuru_anim = Kurakusuru.GetComponent<Animator>();
        Kurakusuru.SetActive(false);
        TitleGo_obj = GameObject.FindWithTag("TitleGo");
        TitleGo_obj.SetActive(false);
        tap_GameOVer_obj.SetActive(false);

        score_best = PlayerPrefs.GetInt ("SCORE", 0);
        score_best_obj = GameObject.FindWithTag("bestScore");
        score_best_txt = score_best_obj.GetComponent<TextMeshProUGUI>();
        score_bestTitle_obj = GameObject.FindWithTag("BestScoreTitle");
        anim_scoreBest = score_best_obj.GetComponent<Animator>();
        anim_scoreBestTitle = score_bestTitle_obj.GetComponent<Animator>();
        KurakusuruStart = GameObject.FindWithTag("暗くするStart");
        KurakusuruStart_anim = KurakusuruStart.GetComponent<Animator>();
        TITLE_obj = GameObject.FindWithTag("TITLE");
        TITLE_anim = TITLE_obj.GetComponent<Animator>();
        coinNum_obj = GameObject.FindWithTag("coinNum");
        coinNum_txt = coinNum_obj.GetComponent<TextMeshProUGUI>();
        coin_num = PlayerPrefs.GetInt("COIN", 0);
        skinGet[1] = PlayerPrefs.GetInt("skinGet1", 0);
        skinGet[2] = PlayerPrefs.GetInt("skinGet2", 0);
        skinGet[3] = PlayerPrefs.GetInt("skinGet3", 0);
        skinGet[4] = PlayerPrefs.GetInt("skinGet4", 0);
        skinGet[5] = PlayerPrefs.GetInt("skinGet5", 0);
        skin_num = PlayerPrefs.GetInt("Skin_num", 0);
        skin_num_max = 5;

        CCVC = CVC_cam.GetComponent<CinemachineVirtualCamera>();

        tap_obj = GameObject.FindWithTag("tap");
        tap_anim = tap_obj.GetComponent<Animator>();
        stageMake = true;

        skinSelect_obj = GameObject.FindWithTag("skinSelect");
        skinSelect_anim = skinSelect_obj.GetComponent<Animator>();
        Hatena_anim = Hatena_obj.GetComponent<Animator>();

        /*
        tap_obj = GameObject.FindWithTag("tap");
        t_sc = tap_obj.GetComponent<tap>();
        tap_txt = tap_obj.GetComponent<TextMeshProUGUI>();
        */
    }

    // Update is called once per frame
    void Update()
    {
        if(skin_num == 0){
            CCVC.Follow = player_obj[0].transform;
            skinBuy[0].SetActive(false);
            skinBuy[1].SetActive(false);
            skinBuy[2].SetActive(false);
            skinBuy[3].SetActive(false);
            skinBuy[4].SetActive(false);

            Lock_obj[0].SetActive(false);
            Lock_obj[1].SetActive(false);
            Lock_obj[2].SetActive(false);
            Lock_obj[3].SetActive(false);
            Lock_obj[4].SetActive(false);

            skin_sprite[0].SetActive(true);
            skin_sprite[1].SetActive(false);
            skin_sprite[2].SetActive(false);
            skin_sprite[3].SetActive(false);
            skin_sprite[4].SetActive(false);
            skin_sprite[5].SetActive(false);

            player_obj[0].SetActive(true);
            player_obj[1].SetActive(false);
            player_obj[2].SetActive(false);
            player_obj[3].SetActive(false);
            player_obj[4].SetActive(false);
            player_obj[5].SetActive(false);
            //player_obj[0] = GameObject.FindWithTag("Player");
            PC = player_obj[0].GetComponent<PlayerController>();
            player_trans = player_obj[0].GetComponent<Transform>();
            pos_player = player_obj[0].transform.position;
            pos_player = player_obj[0].transform.position;
            player_x = player_trans.position.x;
            
        }else if(skin_num == 1){
            skin_sprite[0].SetActive(false);
            skin_sprite[1].SetActive(true);
            skin_sprite[2].SetActive(false);
            skin_sprite[3].SetActive(false);
            skin_sprite[4].SetActive(false);
            skin_sprite[5].SetActive(false);
            if(skinGet[1] == 1)
            {
                CCVC.Follow = player_obj[1].transform;

                Lock_obj[0].SetActive(false);
                Lock_obj[1].SetActive(false);
                Lock_obj[2].SetActive(false);
                Lock_obj[3].SetActive(false);
                Lock_obj[4].SetActive(false);

                skinBuy[0].SetActive(false);
                skinBuy[1].SetActive(false);
                skinBuy[2].SetActive(false);
                skinBuy[3].SetActive(false);
                skinBuy[4].SetActive(false);

                player_obj[0].SetActive(false);
                player_obj[1].SetActive(true);
                player_obj[2].SetActive(false);
                player_obj[3].SetActive(false);
                player_obj[4].SetActive(false);
                player_obj[5].SetActive(false);
                player_obj[1] = GameObject.FindWithTag("Player");

                PC = player_obj[1].GetComponent<PlayerController>();
                player_trans = player_obj[1].GetComponent<Transform>();
                pos_player = player_obj[1].transform.position;
                pos_player = player_obj[1].transform.position;
                player_x = player_trans.position.x;
            }else if(skinGet[1] == 0){
                CCVC.Follow = player_obj[0].transform;
                Lock_obj[0].SetActive(true);
                Lock_obj[1].SetActive(false);
                Lock_obj[2].SetActive(false);
                Lock_obj[3].SetActive(false);
                Lock_obj[4].SetActive(false);

                skinBuy[0].SetActive(true);
                skinBuy[1].SetActive(false);
                skinBuy[2].SetActive(false);
                skinBuy[3].SetActive(false);
                skinBuy[4].SetActive(false);

                player_obj[0].SetActive(true);
                player_obj[1].SetActive(false);
                player_obj[2].SetActive(false);
                player_obj[3].SetActive(false);
                player_obj[4].SetActive(false);
                player_obj[5].SetActive(false);

                PC = player_obj[0].GetComponent<PlayerController>();
                player_trans = player_obj[0].GetComponent<Transform>();
                pos_player = player_obj[0].transform.position;
                pos_player = player_obj[0].transform.position;
                player_x = player_trans.position.x;
            }
        }else if(skin_num == 2){
            skin_sprite[0].SetActive(false);
            skin_sprite[1].SetActive(false);
            skin_sprite[2].SetActive(true);
            skin_sprite[3].SetActive(false);
            skin_sprite[4].SetActive(false);
            skin_sprite[5].SetActive(false);
            if(skinGet[2] == 1)
            {
                Lock_obj[0].SetActive(false);
                Lock_obj[1].SetActive(false);
                Lock_obj[2].SetActive(false);
                Lock_obj[3].SetActive(false);
                Lock_obj[4].SetActive(false);

                CCVC.Follow = player_obj[2].transform;
                skinBuy[0].SetActive(false);
                skinBuy[1].SetActive(false);
                skinBuy[2].SetActive(false);
                skinBuy[3].SetActive(false);
                skinBuy[4].SetActive(false);

                player_obj[0].SetActive(false);
                player_obj[1].SetActive(false);
                player_obj[2].SetActive(true);
                player_obj[3].SetActive(false);
                player_obj[4].SetActive(false);
                player_obj[5].SetActive(false);
                player_obj[2] = GameObject.FindWithTag("Player");
                PC = player_obj[2].GetComponent<PlayerController>();
                player_trans = player_obj[2].GetComponent<Transform>();
                pos_player = player_obj[2].transform.position;
                pos_player = player_obj[2].transform.position;
                player_x = player_trans.position.x;
            }else if(skinGet[2] == 0){

                CCVC.Follow = player_obj[0].transform;
                skinBuy[0].SetActive(false);
                skinBuy[1].SetActive(true);
                skinBuy[2].SetActive(false);
                skinBuy[3].SetActive(false);
                skinBuy[4].SetActive(false);

                Lock_obj[0].SetActive(false);
                Lock_obj[1].SetActive(true);
                Lock_obj[2].SetActive(false);
                Lock_obj[3].SetActive(false);
                Lock_obj[4].SetActive(false);

                skinBuy[0].SetActive(false);
                skinBuy[1].SetActive(true);
                skinBuy[2].SetActive(false);
                skinBuy[3].SetActive(false);
                skinBuy[4].SetActive(false);

                player_obj[0].SetActive(true);
                player_obj[1].SetActive(false);
                player_obj[2].SetActive(false);
                player_obj[3].SetActive(false);
                player_obj[4].SetActive(false);
                player_obj[5].SetActive(false);

                PC = player_obj[0].GetComponent<PlayerController>();
                player_trans = player_obj[0].GetComponent<Transform>();
                pos_player = player_obj[0].transform.position;
                pos_player = player_obj[0].transform.position;
                player_x = player_trans.position.x;
            }
        }else if(skin_num == 3){
            
            skin_sprite[0].SetActive(false);
            skin_sprite[1].SetActive(false);
            skin_sprite[2].SetActive(false);
            skin_sprite[3].SetActive(true);
            skin_sprite[4].SetActive(false);
            skin_sprite[5].SetActive(false);
            if(skinGet[3] == 1)
            {
                Lock_obj[0].SetActive(false);
                Lock_obj[1].SetActive(false);
                Lock_obj[2].SetActive(false);
                Lock_obj[3].SetActive(false);
                Lock_obj[4].SetActive(false);

                CCVC.Follow = player_obj[3].transform;
                skinBuy[0].SetActive(false);
                skinBuy[1].SetActive(false);
                skinBuy[2].SetActive(false);
                skinBuy[3].SetActive(false);
                skinBuy[4].SetActive(false);

                player_obj[0].SetActive(false);
                player_obj[1].SetActive(false);
                player_obj[2].SetActive(false);
                player_obj[3].SetActive(true);
                player_obj[4].SetActive(false);
                player_obj[5].SetActive(false);
                player_obj[3] = GameObject.FindWithTag("Player");
                PC = player_obj[3].GetComponent<PlayerController>();
                player_trans = player_obj[3].GetComponent<Transform>();
                pos_player = player_obj[3].transform.position;
                pos_player = player_obj[3].transform.position;
                player_x = player_trans.position.x;
            }else if(skinGet[3] == 0){
                CCVC.Follow = player_obj[0].transform;
                skinBuy[0].SetActive(false);
                skinBuy[1].SetActive(false);
                skinBuy[2].SetActive(true);
                skinBuy[3].SetActive(false);
                skinBuy[4].SetActive(false);

                Lock_obj[0].SetActive(false);
                Lock_obj[1].SetActive(false);
                Lock_obj[2].SetActive(true);
                Lock_obj[3].SetActive(false);
                Lock_obj[4].SetActive(false);

                player_obj[0].SetActive(true);
                player_obj[1].SetActive(false);
                player_obj[2].SetActive(false);
                player_obj[3].SetActive(false);
                player_obj[4].SetActive(false);
                player_obj[5].SetActive(false);

                PC = player_obj[0].GetComponent<PlayerController>();
                player_trans = player_obj[0].GetComponent<Transform>();
                pos_player = player_obj[0].transform.position;
                pos_player = player_obj[0].transform.position;
                player_x = player_trans.position.x;
            }
        }else if(skin_num == 4){
            skin_sprite[0].SetActive(false);
            skin_sprite[1].SetActive(false);
            skin_sprite[2].SetActive(false);
            skin_sprite[3].SetActive(false);
            skin_sprite[4].SetActive(true);
            skin_sprite[5].SetActive(false);
            if(skinGet[4] == 1)
            {
                Lock_obj[0].SetActive(false);
                Lock_obj[1].SetActive(false);
                Lock_obj[2].SetActive(false);
                Lock_obj[3].SetActive(false);
                Lock_obj[4].SetActive(false);

                CCVC.Follow = player_obj[4].transform;
                skinBuy[0].SetActive(false);
                skinBuy[1].SetActive(false);
                skinBuy[2].SetActive(false);
                skinBuy[3].SetActive(false);
                skinBuy[4].SetActive(false);

                player_obj[0].SetActive(false);
                player_obj[1].SetActive(false);
                player_obj[2].SetActive(false);
                player_obj[3].SetActive(false);
                player_obj[4].SetActive(true);
                player_obj[5].SetActive(false);
                player_obj[4] = GameObject.FindWithTag("Player");
                PC = player_obj[4].GetComponent<PlayerController>();
                player_trans = player_obj[4].GetComponent<Transform>();
                pos_player = player_obj[4].transform.position;
                pos_player = player_obj[4].transform.position;
                player_x = player_trans.position.x;
            }else if(skinGet[4] == 0){
                CCVC.Follow = player_obj[0].transform;
                skinBuy[0].SetActive(false);
                skinBuy[1].SetActive(false);
                skinBuy[2].SetActive(false);
                skinBuy[3].SetActive(true);
                skinBuy[4].SetActive(false);

                Lock_obj[0].SetActive(false);
                Lock_obj[1].SetActive(false);
                Lock_obj[3].SetActive(true);
                Lock_obj[4].SetActive(false);

                player_obj[0].SetActive(true);
                player_obj[1].SetActive(false);
                player_obj[2].SetActive(false);
                player_obj[3].SetActive(false);
                player_obj[4].SetActive(false);
                player_obj[5].SetActive(false);

                PC = player_obj[0].GetComponent<PlayerController>();
                player_trans = player_obj[0].GetComponent<Transform>();
                pos_player = player_obj[0].transform.position;
                pos_player = player_obj[0].transform.position;
                player_x = player_trans.position.x;
            }
        }else if(skin_num == 5){
            skin_sprite[0].SetActive(false);
            skin_sprite[1].SetActive(false);
            skin_sprite[2].SetActive(false);
            skin_sprite[3].SetActive(false);
            skin_sprite[4].SetActive(false);
            skin_sprite[5].SetActive(true);
            if(skinGet[5] == 1)
            {
                Lock_obj[0].SetActive(false);
                Lock_obj[1].SetActive(false);
                Lock_obj[2].SetActive(false);
                Lock_obj[3].SetActive(false);
                Lock_obj[4].SetActive(false);

                CCVC.Follow = player_obj[5].transform;
                skinBuy[0].SetActive(false);
                skinBuy[1].SetActive(false);
                skinBuy[2].SetActive(false);
                skinBuy[3].SetActive(false);
                skinBuy[4].SetActive(false);

                player_obj[0].SetActive(false);
                player_obj[1].SetActive(false);
                player_obj[2].SetActive(false);
                player_obj[3].SetActive(false);
                player_obj[4].SetActive(false);
                player_obj[5].SetActive(true);
                player_obj[5] = GameObject.FindWithTag("Player");
                PC = player_obj[5].GetComponent<PlayerController>();
                player_trans = player_obj[5].GetComponent<Transform>();
                pos_player = player_obj[5].transform.position;
                pos_player = player_obj[5].transform.position;
                player_x = player_trans.position.x;
            }else if(skinGet[5] == 0){
                CCVC.Follow = player_obj[0].transform;
                skinBuy[0].SetActive(false);
                skinBuy[1].SetActive(false);
                skinBuy[2].SetActive(false);
                skinBuy[3].SetActive(false);
                skinBuy[4].SetActive(true);

                Lock_obj[0].SetActive(false);
                Lock_obj[1].SetActive(false);
                Lock_obj[2].SetActive(false);
                Lock_obj[3].SetActive(false);
                Lock_obj[4].SetActive(true);

                player_obj[0].SetActive(true);
                player_obj[1].SetActive(false);
                player_obj[2].SetActive(false);
                player_obj[3].SetActive(false);
                player_obj[4].SetActive(false);
                player_obj[5].SetActive(false);

                PC = player_obj[0].GetComponent<PlayerController>();
                player_trans = player_obj[0].GetComponent<Transform>();
                pos_player = player_obj[0].transform.position;
                pos_player = player_obj[0].transform.position;
                player_x = player_trans.position.x;
            }
        }

        //score_now = score;
        if(score_best < score_now)
        {
            score_best = score_now;
            PlayerPrefs.SetInt ("SCORE", score_best);
            PlayerPrefs.Save ();
            

        }

        //pos_player = player_obj.transform.position;
        if(scoreAlpha_b == true)
        {
            anim_score.SetBool("710", true);
        }else if(scoreAlpha_b == false){
            anim_score.SetBool("710", false);
        }
        
        score_txt.text = ""+ score;
        //float player_x = player_trans.position.x;
        NUM = nowSetPos - player_x;
        
        /*
        if(PC.Start_ == true)
        {
            stageMake = false;
            
        }
        */
        
            //player_x = player_trans.position.x;
        
        coinNum_obj.SetActive(true);
        coinNum_txt.text = "" + coin_num;

        if(PC.GameOver == true)
        {
            int num = 0;
            if(num == 0)
            {
                score_now = score;
                //Debug.Log(score_now);
                anim_score.SetBool("GameOver", true);
                Kurakusuru.SetActive(true);
                Kurakusuru_anim.SetBool("暗くする", true);
                PlayerPrefs.SetInt("COIN", coin_num);
                PlayerPrefs.Save ();
                
                //TitleGo_obj.SetActive(true);
                //tap_GameOVer_obj.SetActive(true);

                num = 1;
            }
            //score_obj.SetActive(false);
            
        }else if(PC.GameStart == true){

            skinSelect_anim.SetBool("GameStart", true);
            KurakusuruStart_anim.SetBool("明るくする", true);
            score_obj.SetActive(true);
            //StartCoroutine("Transparent");
            anim_scoreBest.SetBool("GameStart", true);
            anim_scoreBestTitle.SetBool("GameStart", true);
            TITLE_anim.SetBool("GameStart", true);
            PlayerPrefs.SetInt("Skin_num", skin_num);
            PlayerPrefs.Save();

            GameStart_GM = true;

            
            tap_anim.SetBool("GameStart", true);
            Hatena_anim.SetBool("GameStart", true);
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~PLAYERGET~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
            //player_obj = GameObject.FindWithTag("Player");
            //PC = player_obj.GetComponent<PlayerController>();
            /*player_trans = player_obj.GetComponent<Transform>();
            pos_player = player_obj.transform.position;

            pos_player = player_obj.transform.position;
            player_x = player_trans.position.x;*/
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//            
            
        }else if(PC.GameStart == false){
            KurakusuruStart.SetActive(true);
            score_best_obj.SetActive(true);
            score_best_txt.text = "" + score_best;
            GameStart_GM = false;
            
        }
            if(stageMake == true)
            {
                for(int i = 1; i < 2; i++ )
                {
                    nowSetPos += 60;
                    num = Random.Range(0,stage.Length);
                    Instantiate(stage[num], new Vector3(nowSetPos, 0, 0), Quaternion.identity);
                    Instantiate(HighSANKAKU, new Vector3(nowSetPos, 30,0), Quaternion.identity);
                    Instantiate(LowSANKAKU, new Vector3(nowSetPos, -30,0), Quaternion.identity);
                    Debug.Log("aa");
                    if(i == 1)
                    {
                        stageMake = false;
                    }

                }
            }
            
            if(nowSetPos - player_x <= 30 && nowSetPos - player_x > 10)
            {
                stageMake = true;
            }

        
        
        
        
    }

    public void OnClickLeft()
    {
        if(skin_num == 0){
            skin_num = skin_num_max;

        }else if(skin_num > 0){
            skin_num -= 1;
        }
    }

    public void OnClickRight()
    {
        if(skin_num == skin_num_max){
            skin_num = 0;
        }else if(skin_num < skin_num_max){
            skin_num += 1;
        }
    }

    public void OnClickSkin1()
    {
        if(coin_num >= 1000)
        {
            coin_num-=1000;
            PlayerPrefs.SetInt("COIN", coin_num);
            PlayerPrefs.Save();
            skinGet[1] = 1;
            PlayerPrefs.SetInt("skinGet1", 1);
            PlayerPrefs.Save();
        }
    }

    public void OnClickSkin2()
    {
        if(coin_num >= 5000)
        {
            coin_num-=5000;
            PlayerPrefs.SetInt("COIN", coin_num);
            PlayerPrefs.Save();
            skinGet[2] = 1;
            PlayerPrefs.SetInt("skinGet2", 1);
            PlayerPrefs.Save();
        }
    }

    public void OnClickSkin3()
    {
        if(coin_num >= 5000)
        {
            coin_num-= 5000;
            PlayerPrefs.SetInt("COIN", coin_num);
            PlayerPrefs.Save();
            skinGet[3] = 1;
            PlayerPrefs.SetInt("skinGet3", 1);
            PlayerPrefs.Save();
        }
    }

    public void OnClickSkin4()
    {
        if(coin_num >= 7000)
        {
            coin_num-= 7000;
            PlayerPrefs.SetInt("COIN", coin_num);
            PlayerPrefs.Save();
            skinGet[4] = 1;
            PlayerPrefs.SetInt("skinGet4", 1);
            PlayerPrefs.Save();
        }
    }

    public void OnClickSkin5()
    {
        if(coin_num >= 10000)
        {
            coin_num-= 10000;
            PlayerPrefs.SetInt("COIN", coin_num);
            PlayerPrefs.Save();
            skinGet[5] = 1;
            PlayerPrefs.SetInt("skinGet5", 1);
            PlayerPrefs.Save();
        }
    }

    public void OnClickGameStart()
    {
        PC.GameStart = true;
        //PC.Start_ = true;
        PC.downSpeed = -3;
        PC.tap_count = 1;
        GameStart_obj.gameObject.SetActive(false); 
    }

}
