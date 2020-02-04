using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotSimulator : GateSimulator
{

    public MeshRenderer inputA;
    public MeshRenderer output;

    void Update()
    {
        if (isSimulating && timeCounter >= timeP)
        {
            bool valueA = false;

            if (counter == 0)
            {
                valueA = false;

            }
            else if (counter == 1)
            {
                valueA = true;
            }

            inputA.material = valueA ? onMat : offMat;
            bool outp = NotG.Logic(valueA);
            output.material = outp ? onMat : offMat;

            counter++;

            if (counter >= 2)
            {
                counter = 0;
            }

            timeCounter = 0.0f;
        }
        timeCounter += Time.deltaTime;
    }

}
