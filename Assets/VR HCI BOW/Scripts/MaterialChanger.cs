using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MaterialChangeNotifier : MonoBehaviour
{
    public UnityEvent OnMaterialChanged;

    private Material originalMaterial;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.material;
    }

    private void Update()
    {
        if (meshRenderer.material != originalMaterial)
        {
            originalMaterial = meshRenderer.material;
            OnMaterialChanged.Invoke();
        }
    }
}
