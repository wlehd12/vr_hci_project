using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class Target : MonoBehaviour, IArrowHittable
{
    public float forceAmount = 1.0f;
    public Material otherMaterial = null;
    public GameObject hitEffect;

    public UnityEvent OnMaterialChanged;
    private Material originalMaterial;
    private MeshRenderer meshRenderer;

    public void Hit(Arrow arrow)
    {
        StartCoroutine(ApplyMaterial());
        ApplyForce(arrow.transform.forward);
    }

    void OnTriggerEnter(Collider col)
    {

    }

    private IEnumerator ApplyMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        Material originalMaterial = meshRenderer.material;

        meshRenderer.material = otherMaterial;

        yield return new WaitForSeconds(0.5f);

        meshRenderer.material = originalMaterial;
    }

    private void ApplyForce(Vector3 direction)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(direction * forceAmount);
    }

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.material;
    }

}
