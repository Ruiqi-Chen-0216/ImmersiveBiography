using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceChange : MonoBehaviour {

	// Use this for initialization
	public string Scencename;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public void Scence()
    {
        SceneManager.LoadScene(Scencename);
    }
}
