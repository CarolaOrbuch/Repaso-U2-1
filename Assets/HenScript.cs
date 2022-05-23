using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenScript : MonoBehaviour
{
    public GameObject Sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(Sphere);
            clon.transform.position = transform.position;
        }
    }
}
