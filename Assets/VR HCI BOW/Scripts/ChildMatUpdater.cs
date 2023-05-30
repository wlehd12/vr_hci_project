using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildMatUpdater : MonoBehaviour
{
    private Material originalMaterial;
    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.material;

        MaterialChangeNotifier notifier = GetComponentInParent<MaterialChangeNotifier>();
        if (notifier != null)
        {
            notifier.OnMaterialChanged.AddListener(UpdateMaterial);
        }
    }

    private void UpdateMaterial()
    {
        meshRenderer.material = originalMaterial;
    }
}
