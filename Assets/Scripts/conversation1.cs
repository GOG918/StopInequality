using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Playables;

public class conversation1 : MonoBehaviour
{
    public PlayableDirector myTimeline;
    [SerializeField] private FirstPersonController fps;
    [SerializeField] private GameObject avatar;
    public Animator avatar1animator;
    public GameObject panel1;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            myTimeline.Play();
        }
        if(other.gameObject.tag == "avatar")
        {
            avatar1animator.Play("standing");
        }
        StartCoroutine(wait());
    }


    IEnumerator wait()
    {
        yield return new WaitForSeconds(5f);
        fps.transform.position = new Vector3(14.32708f, 4.310712f, -19.81385f);
        fps.transform.rotation = Quaternion.Euler(0f, -170.653f, 0f);
        fps.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        panel1.SetActive(true);
        avatar.SetActive(true);
    }
}
