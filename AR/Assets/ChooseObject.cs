using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseObject : MonoBehaviour
{
    private ProgrammManager Manager;
    private Button button;
    public GameObject Object;
    void Start()
    {
        Manager = FindObjectOfType<ProgrammManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(ObjectFunction);
    }
    void ObjectFunction()
    {
        Manager.Spawn = Object;
        Manager.chooseObject = true;
    }
    void Update(){}
}
