using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool Logic(bool inA, bool inB)
    {
        bool out1 = NotG.Logic(inA);
        bool out2 = NotG.Logic(inB);
        return NandG.Logic(out1, out2);
    }
}
