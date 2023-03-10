    using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update() => transform.position += Vector3.forward * (speed * Time.deltaTime);
}