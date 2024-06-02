using UnityEngine;

public class EnemyTypeOne : Enemy
{
    [SerializeField] private Material _material;
    [SerializeField] private Renderer _renderer;

    private void Start()
    {
        _renderer.material = _material;
    }
}
