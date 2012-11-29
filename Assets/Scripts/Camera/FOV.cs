using UnityEngine;
using System.Collections;

public class FOV : MonoBehaviour {
    int minFOV = 60;
    int maxFOV = 120;
    public float curFOV;
    public float inFOV;
    public Camera mainCam;
	// Use this for initialization
	void Start () {
	    mainCam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        if (mainCam != Camera.main) {
            mainCam = Camera.main;
        }
        inFOV = Input.GetAxis("FOV");

        curFOV = mainCam.fov;

        curFOV += inFOV;

        //simple filtering
        if (curFOV < minFOV) {
            curFOV = minFOV;
        }
        if(curFOV > maxFOV){
            curFOV = maxFOV;
        }
        //and just to avoid unecesary atributions
        if (curFOV != mainCam.fov){
            mainCam.fieldOfView = curFOV;
        }
	}
}
