using System.Collections;
using UnityEngine;
using UnityEngine.VFX;

public class StopVfx : MonoBehaviour
{
    [SerializeField] private VisualEffect vfx;
    [SerializeField] private float delay;

    private void Start() => StartCoroutine(StopVfx_c());

    private IEnumerator StopVfx_c()
    {
        yield return new WaitForSeconds(delay);
        vfx.Stop();
    }
}