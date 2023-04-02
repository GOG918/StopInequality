using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class conversation3 : MonoBehaviour
{
    [SerializeField] private FirstPersonController fps;
    [SerializeField] private Camera fps1;
    [SerializeField] private Camera camera1;
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
        fps.transform.position = new Vector3(32.67f, 4.32f, -31.12f);
        fps.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        fps.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        fps1.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        panel2.SetActive(true);
        camera1.enabled = true;
    }
}
