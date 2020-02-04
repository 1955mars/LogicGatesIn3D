using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndG : MonoBehaviour
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
        bool out1 = NandG.Logic(inA, inB);
        return NotG.Logic(out1);
    }
}
