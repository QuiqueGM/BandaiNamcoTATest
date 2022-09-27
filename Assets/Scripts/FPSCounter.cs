using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
	private const float updateInterval = 0.5f;

	private float time = 0.0f;
	private int frames = 0;
	private float timeToUpdate;
	private float fps;

	public TMP_Text text_fps;
	
	private void Start()
	{
		timeToUpdate = updateInterval;
	}
	
	private void Update()
	{
		timeToUpdate -= Time.deltaTime;
		time += Time.deltaTime;
		++frames;

		if (timeToUpdate <= 0.0)
		{
			fps = 1.0f / (time / frames);
			
			time = 0.0f;
			frames = 0;
			timeToUpdate = updateInterval;

			text_fps.text = fps.ToString("F2");
		}
	}
}