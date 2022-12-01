using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ProgrammManager : MonoBehaviour
{
    private GameObject PlaneMarker;
    private ARRaycastManager ARRaycastManagerScript;
    private Vector2 TouchPosition;
    public GameObject Spawn;
    public bool chooseObject = false;
    void Start()
    {
        ARRaycastManagerScript = FindObjectOfType<ARRaycastManager>();
        PlaneMarker.SetActive(false);
    }

    void Update()
    {

        if (chooseObject)
        {
            ShowMarker();
        }   
    }
    void ShowMarker()
    {   
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        ARRaycastManagerScript.Raycast(new Vector2(Screen.width/2, Screen.height/2), hits, TrackableType.Planes);
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Instantiate(Spawn, hits[0].pose.position, Spawn.transform.rotation);
            chooseObject = false;
        }

    }
}
