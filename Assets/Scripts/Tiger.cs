using System.Collections;
using UnityEngine;

public class Tiger : MonoBehaviour
{
    [SerializeField] private float erodeRate = 0.015f;
    [SerializeField] private float erodeRefreshRate = 0.01f;
    [SerializeField] private float erodeDelay = 1.25f;
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;
    private static readonly int Erode = Shader.PropertyToID("_Erode");

    private void Start() => StartCoroutine(Erode_c());

    private IEnumerator Erode_c()
    {
        yield return new WaitForSeconds(erodeDelay);

        float time = 0;
        while (time < 1)
        {
            time += erodeRate;
            skinnedMeshRenderer.material.SetFloat(Erode, time);
            yield return new WaitForSeconds(erodeRefreshRate);
        }
    }
}