using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {

    private GameObject[] basicblocks;
    private GameObject[] lavablocks;
    private GameObject[] waterblocks;

    public Material lavaMaterial;
    public Material waterMaterial;

	// Use this for initialization
	void Start () {
        basicblocks = GameObject.FindGameObjectsWithTag("Ground");
        lavablocks = GameObject.FindGameObjectsWithTag("Lava");
        waterblocks = GameObject.FindGameObjectsWithTag("Water");

        foreach (GameObject block in lavablocks) {
            for (int i = 1; i < block.transform.childCount; i++) {
                block.transform.GetChild(i).GetComponent<Renderer>().material = lavaMaterial;
            }
        }
        foreach (GameObject block in waterblocks) {
            for (int i = 1; i < block.transform.childCount; i++) {
                block.transform.GetChild(i).GetComponent<Renderer>().material = waterMaterial;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
