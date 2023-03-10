using UnityEngine;

public class DestroyDelay : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float delay;

    private void Start() => Destroy(target, delay);
}