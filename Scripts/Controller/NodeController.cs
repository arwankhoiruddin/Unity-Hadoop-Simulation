using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController
{

    NodeView nodeView;
    NodeModel nodeModel;

    public NodeController(NodeView nodeView, NodeModel nodeModel)
    {

        this.nodeView = nodeView;
        this.nodeModel = nodeModel;
        
        initNode();

    }


    void initNode() {
                
        this.nodeView.gameObject.transform.localPosition = new Vector3(nodeView.xPos, nodeView.yPos, 0);
        this.nodeView.gameObject.transform.localScale = new Vector3(10, 10, 10);
        this.nodeView.gameObject.GetComponent<Renderer>().material.color = Color.red;

        Rigidbody rb = this.nodeView.gameObject.AddComponent<Rigidbody>();

    }


    public void moveNode(int x, int y, int z) {

        Rigidbody rb = this.nodeView.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(x, y, z);

    }
}
