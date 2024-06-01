using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform _pointOne;
    [SerializeField] private Transform _pointTwo;
    [SerializeField] private float _speed;

    private void Start()
    {
        transform.position = _pointOne.position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _pointTwo.position, _speed * Time.deltaTime);
        Vector3 direction = _pointTwo.position - transform.position;
        transform.rotation = Quaternion.LookRotation(direction);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<EnemyTypeOne>(out EnemyTypeOne enemyTypeOne) || other.TryGetComponent<EnemyTypeTwo>(out EnemyTypeTwo enemyTypeTwo))
        {
            Destroy(other.gameObject);
        }
    }
}
