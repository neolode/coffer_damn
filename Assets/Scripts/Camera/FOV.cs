using UnityEngine;
using System.Collections;

public class FOV : MonoBehaviour {
    int minFOV = 65;
    int maxFOV = 120;
    public float curFOV;
    public float inFOV;
    public Camera mainCam;
	// Use this for initialization
	void Start () {
		if(Camera.main != null)
	    	mainCam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		if(Camera.main == null){
			Debug.Log("No MainCamera defined for FOV.cs");
			return;
		}
        if (mainCam != Camera.main) {
            mainCam = Camera.main;
        }
        inFOV = Input.GetAxis("FOV");

		curFOV = mainCam.fieldOfView;

        curFOV += inFOV;

        //simple filtering
        if (curFOV < minFOV) {
            curFOV = minFOV;
        }
        if(curFOV > maxFOV){
            curFOV = maxFOV;
        }
        //and just to avoid unecesary atributions
		if (curFOV != mainCam.fieldOfView){
            mainCam.fieldOfView = curFOV;
			//Debug.Log("FOV set to:" + curFOV);
			
        }
		
	}
}
