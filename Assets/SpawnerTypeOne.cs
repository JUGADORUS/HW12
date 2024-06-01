using System.Collections;
using UnityEngine;

public class SpawnerTypeOne : MonoBehaviour
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

            if (_enemy.TryGetComponent<EnemyTypeOne>(out EnemyTypeOne enemy))
            {
                _enemy.GetComponent<EnemyTypeOne>().Target = _target;
            }
        }
    }
}
