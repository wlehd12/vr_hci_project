using UnityEngine;

public class ChangeColor : MonoBehaviour, IArrowHittable
{
    public Material otherMaterial = null;

    public void Hit(Arrow arrow)
    {
        ApplyMaterial();
    }

    private void ApplyMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = otherMaterial;
    }

    void Start()
    {
        
    }
}
