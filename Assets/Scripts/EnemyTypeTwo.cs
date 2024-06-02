using UnityEngine;

public class EnemyTypeTwo : Enemy
{
    [SerializeField] private Renderer _renderer;

    private void Start()
    {
        SetColor();
    }

    private void SetColor()
    {
        float randomChannelOne = Random.Range(0f, 1f);
        float randomChannelTwo = Random.Range(0f, 1f);
        float randomChannelThree = Random.Range(0f, 1f);

        _renderer.material.color = new Color(randomChannelOne, randomChannelTwo, randomChannelThree);
    }
}
