using UnityEngine;

public class StickToGround : MonoBehaviour
{
    private void Update() => Stick();

    private void Stick()
    {
        Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.down));
        if (Physics.Raycast(ray, out var hit, 250))
        {
            transform.position = new Vector3(transform.position.x, hit.point.y, transform.position.z);
        }
    }
}