using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class conversation2 : MonoBehaviour
{
    [SerializeField] private FirstPersonController fps;
    public GameObject panel2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(10f);
        fps.transform.position = new Vector3(32.8f, 4.26f, -36.31f);
        fps.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        fps.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        panel2.SetActive(true);
    }
}
