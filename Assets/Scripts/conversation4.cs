using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityStandardAssets.Characters.FirstPerson;

public class conversation4 : MonoBehaviour
{
    [SerializeField] private FirstPersonController fps;
    public GameObject panel2;
    public PlayableDirector myTimeline;
    
    // Start is called before the first frame update
    void Start()
    {
        myTimeline.Play();
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(10f);
        fps.transform.position = new Vector3(25.2381f, 4.384792f, -34.1102f);
        fps.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        fps.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        panel2.SetActive(true);
    }
}
