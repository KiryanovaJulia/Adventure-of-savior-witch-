using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousescr : MonoBehaviour
{

    public GameObject part;
    public Vector2 mousep;

    // Start is called before the first frame update
    void Start()
    {
        part.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mousep = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            part.SetActive(true);
            part.transform.position = new Vector3(mousep.x,
                                                  mousep.y,
                                                  0f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            part.SetActive(false);
        }
    }
}
