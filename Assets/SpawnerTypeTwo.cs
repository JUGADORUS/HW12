using System.Collections;
using UnityEngine;

public class SpawnerTypeTwo : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _target;

    private int _delay = 2;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(_delay);
            Instantiate(_enemy, transform.position, Quaternion.identity);

            if (_enemy.TryGetComponent<EnemyTypeTwo>(out EnemyTypeTwo enemy))
            {
                _enemy.GetComponent<EnemyTypeTwo>().Target = _target;
            }
        }
    }
}
