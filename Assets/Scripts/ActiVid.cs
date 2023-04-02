using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;



public class ActiVid : MonoBehaviour
{
    public GameObject canvas;
    string choice = "a";
    private bool cond=false;
    private bool changesc = false;
    private string goodchoice;
    Color col1 = new Color(0.04f, 0.45f,0.08f);
    Color col2 = new Color(0.8f, 0.8f, 0.0f);
    [SerializeField] UnityEngine.UI.RawImage im1;
    [SerializeField] UnityEngine.UI.RawImage im2;
    [SerializeField] UnityEngine.UI.RawImage im3;
    [SerializeField] UnityEngine.UI.RawImage im4;
    [SerializeField] UnityEngine.UI.RawImage imP;
    [SerializeField] TextMeshProUGUI tx1;
    [SerializeField] TextMeshProUGUI tx2;
    [SerializeField] TextMeshProUGUI tx3;
    [SerializeField] TextMeshProUGUI txS;
    [SerializeField] UnityEngine.Video.VideoPlayer vid;
    GameManagerSingleton SceneManager;
    [SerializeField] private FirstPersonController fps;
    [SerializeField] private GameObject avatar;
    [SerializeField] private Button LastButtonConversation1;
    [SerializeField] private Text succesText;
    [SerializeField] private GameObject canvas1;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager = GameObject.Find("SceneManager").GetComponent<GameManagerSingleton>();
        StartCoroutine(wait4());
        //StartCoroutine(wait());
        //Debug.Log(vid.clip.length);
        //im4.enabled = false;
        im1.color = col1;
        im2.color = col1;
        im3.color = col1;
        vid.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {

            im1.color = col2;
            im2.color = col1;
            im3.color = col1;
            choice = "a";
            goodchoice = im1.name;
        }
        if (Input.GetKeyDown("x"))
        {
            im1.color = col1;
            im2.color = col2;
            im3.color = col1;
            choice = "b";
            goodchoice = im2.name;
        }
        if (Input.GetKeyDown("c"))
        {
            im1.color = col1;
            im2.color = col1;
            im3.color = col2;
            choice = "c";
            goodchoice = im3.name;
        }
        //(choice != "c")
        if ((Input.GetKeyDown("m")) && (cond == true) && (goodchoice == "badchoice"))
        {
            Debug.Log("failure");
            StartCoroutine(wait2());
            im4.enabled = true;
            im1.enabled = false;
            im2.enabled = false;
            im3.enabled = false;
            tx1.enabled = false;
            tx2.enabled = false;
            tx3.enabled = false;
            vid.Play();
            cond = false;
            succesText.text = "Mauvais choix";
        }
        if ((Input.GetKeyDown("m")) && (cond == true) && (goodchoice == "middlechoice"))
        {
            Debug.Log("failure");
            StartCoroutine(wait2());
            im4.enabled = true;
            im1.enabled = false;
            im2.enabled = false;
            im3.enabled = false;
            tx1.enabled = false;
            tx2.enabled = false;
            tx3.enabled = false;
            vid.Play();
            cond = false;
            succesText.text = "bon choix";
        }
        if ((Input.GetKeyDown("m"))&& (cond==true)&& (goodchoice == "goodchoice"))
        {
            Debug.Log("success");
            im4.enabled = false;
            im1.enabled = false;
            im2.enabled = false;
            im3.enabled = false;
            tx1.enabled = false;
            tx2.enabled = false;
            tx3.enabled = false;
            cond = false;
            imP.enabled = true;
            succesText.text = " très bon choix";
            StartCoroutine(wait3());
            //SceneManager.LoadSceneFromString(txS.text);
        }
        if (changesc == true)
        {
            StartCoroutine(wait3());
            changesc = false;
        }
    }
     public void choice1()
    {
        canvas.SetActive(true);
        cond = true;
        vid.Pause();
        Debug.Log(choice);  
    }

    IEnumerator wait2()
    {
        //yield return new WaitForSeconds((float)(vid.clip.length-1)); 
        yield return new WaitForSeconds(30f);
        vid.Pause();
        im4.enabled = false;
        imP.enabled = true;
        changesc = true;
        //wait3();
    }

    IEnumerator wait3()
    {
        yield return new WaitForSeconds(7f);
        imP.enabled = false;
        SceneManager.LoadSceneFromString(txS.text);
        //Debug.Log(txS.text);
    }

    IEnumerator wait4()
    {
        canvas1.SetActive(true);
        yield return new WaitForSeconds(10f);
        canvas1.SetActive(false);
        //Debug.Log(txS.text);
    }

    public void Scene1Ch()
    {
        GameManagerSingleton.Instance.LoadSceneFromString("Scene1");
    }

    public void Scene2Ch()
    {
        GameManagerSingleton.Instance.LoadSceneFromString("Scene2");
    }
    public void Scene3Ch()
    {
        GameManagerSingleton.Instance.LoadSceneFromString("Scene3");
    }
    public void Scene4Ch()
    {
        GameManagerSingleton.Instance.LoadSceneFromString("Scene4");
        //GameManagerSingleton.Instance.LoadSceneFromString("finish");
    }

    /*    public void Hi()
        {
            Debug.Log("hi");
        }*/
}
