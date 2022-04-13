using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = {1,3,5,7,9};
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[4 - i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
