using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] cubes;
    public GameObject camer;
    public GameObject lig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   
    {
        float v = 0;
        foreach (GameObject cube in cubes)
        {
            // float yNew = Mathf.Sin(Time.time);
            float xNew1 = Mathf.Cos(Time.time) ;
            // cube.transform.position += new Vector3(xNew * Time.deltaTime, transform.position.y, transform.position.z);
            // cube.transform.position = new Vector3(xNew1 , yNew+v, 0);
            cube.transform.rotation = Quaternion.Euler(new Vector3(0,0, xNew1 * 60f + v));
            v +=10;
        }
        float cX = Mathf.PingPong(Time.time , 10);
        camer.transform.position = new Vector3(0, 0, cX);
        lig.transform.position = new Vector3(0, 0, cX+5);
        
    }
}
