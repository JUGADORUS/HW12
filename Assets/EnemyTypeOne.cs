using UnityEngine;

public class EnemyTypeOne : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] public GameObject Target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, _speed*Time.deltaTime);
        Vector3 direction = Target.transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
