using UnityEngine;

public class ItemBobbing : MonoBehaviour
{
    public float amplitude = 0.25f;
    public float frequency = 1f;
    public float rotationSpeed = 45f;

    private Vector3 localStartPos;

    private void Start()
    {
        localStartPos = transform.localPosition;
    }

    private void Update()
    {
        float offset = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.localPosition = localStartPos + new Vector3(0, offset, 0);

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
    }
}
