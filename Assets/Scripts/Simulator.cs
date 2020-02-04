using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Simulator : MonoBehaviour
{
    public GameObject[] GatePrefabs;
    public Transform SimPos;
    public Text SimName; 

    public float SimSpeed = 1.0f;
    public float SimRotSpeed = 10.0f;

    int numGates = 0;
    Simulate currentSim;
    GameObject currentSimObj;
    int currentSimIndex = 0;

    bool isRotating = false;
    bool isAutoSim = false;

    float currAutoSimTime = 0.0f;

    Quaternion simInitRot;

    // Start is called before the first frame update
    void Start()
    {
        numGates = GatePrefabs.Length;

        StartSim();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            isAutoSim = !isAutoSim;
        }

        if(isAutoSim)
        {
            currAutoSimTime += Time.deltaTime;
        }

        if((isAutoSim && currAutoSimTime >= SimSpeed) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            StopSim();

            currentSimIndex++;
            if (currentSimIndex >= numGates)
                currentSimIndex = 0;

            StartSim();

            if(isAutoSim)
            {
                currAutoSimTime = 0.0f;
            }

        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StopSim();

            currentSimIndex--;
            if (currentSimIndex < 0)
                currentSimIndex = numGates-1;

            StartSim();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            isRotating = !isRotating;
            currentSimObj.transform.rotation = simInitRot;
        }

        if(isRotating)
        {
            currentSimObj.transform.Rotate(Vector3.up * SimRotSpeed * Time.deltaTime, Space.World);
        }
    }

    void StopSim()
    {
        currentSim.StopSimulation();
        Destroy(currentSimObj);
    }

    void StartSim()
    {
        currentSimObj = Instantiate(GatePrefabs[currentSimIndex], SimPos);
        currentSim = currentSimObj.GetComponent<Simulate>();
        currentSim.StartSimulation(SimSpeed);

        simInitRot = currentSimObj.transform.rotation;

        SimName.text = currentSim.SimName();
    }
}
