// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezarato

// Atividade N1 - Professora Lucy Mari (LogAlg)

// Código de geração do chão

using UnityEngine;

public class GroundSpawner : MonoBehaviour {

    [SerializeField] GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile (bool spawnItems)
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
        temp.transform.tag="Ground";

        if (spawnItems) {
            temp.GetComponent<GroundTile>().SpawnObstacle();
            temp.GetComponent<GroundTile>().SpawnCoins();
        }
    }

    private void Start () { // Estrutura de repetição
        for (int i = 0; i < 15; i++) { // Máximo de 15 spaws
            if (i < 3) { 
                SpawnTile(false);
            } else {
                SpawnTile(true);
            }
        }
    }
}