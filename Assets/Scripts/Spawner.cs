using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Target _target;

    private int _delay = 2;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(_delay);
            Instantiate(_enemy, transform.position, Quaternion.identity);

            if (_enemy.TryGetComponent<Enemy>(out Enemy enemy))
            {
                _enemy.GetComponent<Enemy>().Target = _target.transform;
            }
        }
    }
}
