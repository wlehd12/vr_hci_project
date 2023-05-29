using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentMatApplier : MonoBehaviour
{
    private Renderer parentRenderer;
    private Renderer childRenderer;

    // Start is called before the first frame update
    void Start()
    {
        parentRenderer = GetComponentInParent<Renderer>();

        childRenderer = GetComponent<Renderer>();

        if (parentRenderer != null && childRenderer != null)
        {
            Material parentMaterial = parentRenderer.material;

            childRenderer.material = parentMaterial;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
