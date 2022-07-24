using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HadoopSimulation : MonoBehaviour
{
    // Start is called before the first frame update
    NodeModel[] nodeModel = new NodeModel[Configs.numNodes];
    NodeView[] nodeView = new NodeView[Configs.numNodes];
    NodeController[] nodeController = new NodeController[Configs.numNodes];

    void Start()
    {
        Debug.Log("In start");

        for (int i=0; i < Configs.numNodes; i++) {
            int xPos = (i * (2 * Configs.nodeSize));
            nodeView[i] = new NodeView();
            nodeModel[i] = new NodeModel(xPos, 0, 0);
            nodeController[i] = new NodeController(nodeView[i], nodeModel[i]);
            Debug.Log("Node number" + i + " created");
        }

    }

    // Update is called once per frame
    void Update()
    {
        setLeftStatus(Configs.timeCounter++);
        for (int i=0; i < Configs.numNodes; i++) {
            if (Configs.isLeft)
                nodeController[i].moveNode(Configs.xForce, 0, 0);
            else
                nodeController[i].moveNode(-Configs.xForce, 0, 0);
        }
    }

    void setLeftStatus(int counter) {
        if (counter % 1000 == 0) {
            if (Configs.isLeft) {
                Configs.isLeft = false;
            } else {
                Configs.isLeft = true;
            }
            counter++;
        }
    }
}
