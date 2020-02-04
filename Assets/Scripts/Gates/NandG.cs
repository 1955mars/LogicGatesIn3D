using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NandG : MonoBehaviour
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
        return !(inA && inB);
    }


}
