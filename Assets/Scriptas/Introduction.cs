using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public int Str;
    public int healthPts;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        healthPts = 5 * Str;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World!");
 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage();
        }
        if (healthPts<0)
        {
            Debug.Log("You're Dead");
            healthPts = 0;
        }
    }
    void TakeDamage()
    {
        healthPts -= damage;
    }
}

 