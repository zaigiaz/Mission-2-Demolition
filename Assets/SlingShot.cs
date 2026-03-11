using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShot : MonoBehaviour
{

    public GameObject launchPoint;

    void Awake() {
	Transform launchPointTrans = transform.Find("LaunchPoint");
	launchPoint = launchPointTrans.gameObject;
	launchPoint.SetActive(false); 	
    }

    void OnMouseEnter() {
	// print("SlingShot:onMouseEnter()");
	launchPoint.SetActive(true);
    }

    void OnMouseExit() {
        // print("SlingShot:onMouseExit()");
	launchPoint.SetActive(false);
    }
}
