// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezarato

// Atividade N1 - Professora Lucy Mari (LogAlg)

// Código de geração aleatória dos objetos do cenário

using UnityEngine;

public class GroundTile : MonoBehaviour {

    GroundSpawner groundSpawner;
    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject arbustoPrefab;

    private void Start () {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();

	}

    private void OnTriggerExit (Collider other)
    {
        groundSpawner.SpawnTile(true);
        Destroy(gameObject, 2);
    }

    public void SpawnArbusto ()
    {
        int arbustoSpawnIndex = Random.Range(2, 5); // Ponto aleatório para gerar obstáculos
        Transform spawnPoint = transform.GetChild(arbustoSpawnIndex).transform;

        Instantiate(arbustoPrefab, spawnPoint.position, Quaternion.identity, transform); // Gerar obstáculos na posição
    }

    public void SpawnObstacle ()
    {
        int obstacleSpawnIndex = Random.Range(2, 5); // Ponto aleatório para gerar obstáculos
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform); // Gerar obstáculos na posição
    }

    public void SpawnCoins ()
    {
        int coinsToSpawn = 5;
        for (int i = 0; i < coinsToSpawn; i++) {
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider (Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if (point != collider.ClosestPoint(point)) {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }
}