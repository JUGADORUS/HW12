using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public Transform Target;
    [SerializeField] private float _speed;

    private void Update()
    {
        MoveToTarget(Target);
    }

    private void MoveToTarget(Transform target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
        Vector3 direction = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
