using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideHandler : MonoBehaviour
{
	public Slider slider;
	public Text percentage_txt;

	IEnumerator Start()
	{
		slider.value = 0.0f;
		float value = 0.0f;

		while (value <= 100.0f)
		{
			yield return new WaitForSeconds(1.0f);
			UpdateSlider(value);
			value += 10.0f;
		}

	}

	void UpdateSlider(float value)
	{
		slider.value = value;
		percentage_txt.text = slider.value.ToString();
	}

}
