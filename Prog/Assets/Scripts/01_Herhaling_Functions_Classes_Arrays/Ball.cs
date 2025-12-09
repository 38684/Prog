using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Color color = RandomColor();
            Vector3 randPos = RandomPosition(-10f, 10f);
            CreateBall(color, randPos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
            Color color = RandomColor();
            Vector3 randomPosition = RandomPosition(-10f, 10f);
            GameObject ball = CreateBall(color, randomPosition);
            StartCoroutine(DestroyBall(ball));
            elapsedTime = 0f;
        }
    }

    private GameObject CreateBall(Color color, Vector3 randomPosition)
    {

        GameObject ball = Instantiate(prefab, randomPosition, new Quaternion(0, 0, 0, 0));
        Material material = ball.GetComponent<MeshRenderer>().material;

        material.SetColor("_Color", color);

        if (material.shader.name == "Universal Render Pipeline/Lit")
        {
            material.SetColor("_BaseColor", color);
        }

        return ball;
    }

    IEnumerator DestroyBall(GameObject ball)
    {
        yield return new WaitForSeconds(1);
        Destroy(ball);
    }

    private Color RandomColor()
    {
        Color randomColor = Random.ColorHSV(0, 1, 0, 1, 0, 1, 1, 1);

        return randomColor;
    }

    private Vector3 RandomPosition(float minimumRange, float maximumRange)
    {
        float x = Random.Range(minimumRange, maximumRange);
        float y = Random.Range(minimumRange, maximumRange);
        float z = Random.Range(minimumRange, maximumRange);

        return new Vector3(x, y, z);
    }
}
