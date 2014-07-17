using UnityEngine;
using System.Collections;

public class FOVFeedback : MonoBehaviour {
	TextMesh textMesh;
	public string text;
	// Use this for initialization
	void Start () {
	 textMesh = (TextMesh)gameObject.GetComponent("TextMesh");
	}
	
	// Update is called once per frame
	void Update () {
		text = "FOV: " + Camera.main.fieldOfView;
		
		textMesh.text = text.ToString();
	}
}
