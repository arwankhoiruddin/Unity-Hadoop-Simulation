using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HadoopSimulation : MonoBehaviour
{
    
    // Initialize the simulation
    NodeModel[] nodeModel = new NodeModel[Configs.numNodes];
    NodeView[] nodeView = new NodeView[Configs.numNodes];
    NodeController[] nodeController = new NodeController[Configs.numNodes];

    SimulationController simulationController = new SimulationController();

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("In start");

        // generate CPU, RAM and Disk Specifications
        int[] cpuSpec = simulationController.generateSpec(1, 10);
        int[] ramSpec = simulationController.generateSpec(1, 10);
        int[] diskSpec = simulationController.generateSpec(1, 10);

        for (int i=0; i < Configs.numNodes; i++) {
            int xPos = (i * (2 * Configs.nodeSize));
            nodeView[i] = new NodeView(xPos, 0, 0);
            nodeModel[i] = new NodeModel(cpuSpec[i], ramSpec[i], diskSpec[i]);
            nodeController[i] = new NodeController(nodeView[i], nodeModel[i]);
            Debug.Log("Node number" + i + " created");
        }

        Configs.status = SimulationState.DATA_SUBMISSION;
        Configs.nextDuration = 100;

    }


    // Update is called once per frame
    void Update()
    {

        switch (Configs.status)
        {
            case SimulationState.DATA_SUBMISSION:
                Debug.Log("In data submission");
                Configs.nextDuration = 200;
                break;
            case SimulationState.BLOCK_CREATION:
                Debug.Log("In block creation");
                Configs.nextDuration = 300;
                break;
            case SimulationState.BLOCK_TRANSFER:
                Debug.Log("In block transfer");
                Configs.nextDuration = 400;
                break;
            case SimulationState.MAP:
                Debug.Log("In map");
                Configs.nextDuration = 500;
                break;
            case SimulationState.SHUFFLE:
                Debug.Log("In shuffle");
                Configs.nextDuration = 600;
                break;
            case SimulationState.SORT:
                Debug.Log("In sort");
                Configs.nextDuration = 700;
                break;
            case SimulationState.REDUCE:
                Debug.Log("In reduce");
                Configs.nextDuration = 800;
                break;
        }
        simulationController.setTimerState();

    }

    
}
