using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class male_parts : MonoBehaviour
{
    [SerializeField] Transform full_Body;
    [SerializeField] Transform right_Arm;

    [SerializeField] float x=1,z=1;
    float y = 1;

    [SerializeField] float x1 = 1, z1 = 1;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        

        full_Body.localScale = new Vector3(x,y,z);
        right_Arm.localScale = new Vector3(x1, y, z1);
        //  x+=0.001f;

    }
}
