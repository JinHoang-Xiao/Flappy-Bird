using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _obstacle;
    [SerializeField]
    private PlayerController _bird;
    
    private float _spawnFrequency = 2.5f;
    private float _timeTillNextSpawn = 0f;

    void Update()
    {
        if (_timeTillNextSpawn <= 0f && _bird.IsAlive)
        {
            Vector3 newPosition= new Vector3(transform.position.x, Random.Range(1f, 3f));
            Instantiate(_obstacle, newPosition, transform.rotation);
            _timeTillNextSpawn = _spawnFrequency;
        }
        else
        {
            _timeTillNextSpawn -= Time.deltaTime;
        }
    }
}
