using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Or8WayC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool Logic(bool[] inA)
    {
        if (inA.Length != 8 )
        {
            Debug.Log("Wrong input to Not16");
            Application.Quit();
        }
        bool[] output1 = new bool[4];
        for (int i = 0; i < 8; i=i+2)
        {
            output1[i/2] = OrG.Logic(inA[i], inA[i+1]);
        }
        bool[] output2 = new bool[2];
        for (int i = 0; i < 4; i = i + 2)
        {
            output2[i/2] = OrG.Logic(output1[i], output1[i + 1]);
        }
        return OrG.Logic(output2[0], output2[1]);
    }
}
