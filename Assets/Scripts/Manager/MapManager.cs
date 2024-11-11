using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MapManager : Singleton<MapManager>
{
    public Queue<GameObject> Chunks;
    public GameObject block;
    public Transform parent;
    public Transform Party;
    private Vector3 _nextChunkPosition;
    public int ChunkLevel;
    public int size;


    private void Awake()
    {
        _nextChunkPosition = new Vector3(0, -1, 0);
        Chunks = new Queue<GameObject>();
        for (int i = 0; i < size; i++)
        {
            GameObject obj = Instantiate(block, parent);
            Chunks.Enqueue(obj);
            obj.SetActive(false);
        }
    }

    private void Start()
    {
        for (int i = 0; i < size; i++)
        {
            MakeChunk();
        }
    }

    private void Update()
    {
        if (Party.position.z > _nextChunkPosition.z - 60f)
        {
            MakeChunk();
        }
    }

    private void MakeChunk()
    {
        GameObject obj = Chunks.Dequeue();
        obj.transform.position = _nextChunkPosition;
        _nextChunkPosition.z += 6f;
        obj.SetActive(true);
        Chunks.Enqueue(obj);
    }
}