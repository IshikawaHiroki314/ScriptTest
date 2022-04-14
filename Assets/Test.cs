using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp);
        }
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}
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

        Boss lastboss = new Boss();
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
