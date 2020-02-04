using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSimulator : MonoBehaviour, Simulate
{
    public string name;

    public Material onMat;
    public Material offMat;

    protected bool isSimulating = false;
    protected float timeP = 1.0f;

    protected float timeCounter = 0.0f;
    protected int counter = 0;

    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    public void StartSimulation(float timePeriod)
    {
        timeP = timePeriod;
        isSimulating = true;
    }

    public void StopSimulation()
    {
        isSimulating = false;
    }

    public string SimName()
    {
        return name;
    }
}
