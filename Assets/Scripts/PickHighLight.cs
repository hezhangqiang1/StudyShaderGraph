using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickHighLight : MonoBehaviour
{
    private MeshRenderer originalMesh;
    [SerializeField]
    private MeshRenderer highLightMesh;

    private void Start()
    {
        originalMesh = GetComponent<MeshRenderer>();
        EnableHighLightMesh(false);
    }

    private void EnableHighLightMesh(bool onOff)
    {
        if (highLightMesh != null)
        {
            highLightMesh.enabled = onOff;
            originalMesh.enabled = !onOff;
        }
    }

    private void OnMouseEnter()
    {
        EnableHighLightMesh(true);
    }
    private void OnMouseExit()
    {
        EnableHighLightMesh(false);
    }
    

}
