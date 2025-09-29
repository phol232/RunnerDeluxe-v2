using UnityEngine;

public class SmoothLookAtTurret : MonoBehaviour
{
    public Transform target;
    [Range(0.1f, 10f)]

    public float rotattionSpeed = 5f;

    private void Update()
    {
        if (target == null) return;

        Vector3 directionToTarget = target.position - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotattionSpeed * Time.deltaTime);


    }
}
