using System.Linq;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _speed;

    private int _index = 0;

    private void Start()
    {
        transform.position = _points[_index].position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _points[_index].position, _speed * Time.deltaTime);
        Vector3 direction = _points[_index].position - transform.position;
        transform.rotation = Quaternion.LookRotation(direction);

        if(transform.position == _points[_index].position)
        {
            _index++;

            if(_index == _points.Count())
            {
                _index = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Enemy>(out Enemy enemy))
        {
            Destroy(other.gameObject);
        }
    }
}
