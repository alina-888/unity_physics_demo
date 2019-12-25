// импортируем библиотеки
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

// декларируем класс
public class GravityUpdateScript : MonoBehaviour
{
	// задаем константы
	const float EARTH_G = 9.8f;
 	const float MOON_G = 1.6f;
	const float SPACE_G = 0f;
 
	    	
	// переменные компонентов UI
	public Slider mySlider;
	public Text gravityText;
        public Dropdown myDropdown;

    // Start is called before the first frame update
    // стандартный метод Start вызывается перед первым обновлением кадра
    void Start()
    {
	
	Debug.Log("Hello, world!");            
	

	// добавляем Listeners(слушателей) для Slider.onValueChanged
	mySlider.onValueChanged.AddListener (delegate {ChangeGravity();});
	// добавляем Listeners(слушателей) для Dropdown.onValueChanged
	myDropdown.onValueChanged.AddListener(delegate {DropdownChooseGravity(myDropdown);});

	mySlider.value = EARTH_G;
        		
    }



// задаем метод для dropdown
 public void DropdownChooseGravity(Dropdown d) {
	int index = d.value;
		
      switch (index)
      {
    	case 0:
               //Земля
	       mySlider.value = EARTH_G;
		break;
        case 1:
	      //Луна	
              mySlider.value = MOON_G;
		break;
          case 2:
	      //Космос
              mySlider.value = SPACE_G;
              break;
          default:
              break;
      }
}

// задаем метод для изменения гравитации 
 public void ChangeGravity() {
	// обновляем текст
 	gravityText.text = "Gravity :" + Math.Round(mySlider.value);
	// изменяем гравитацию в физическом движке	
 	Physics.gravity = new Vector3(0, -mySlider.value, 0);
}



    // Update is called once per frame
    void Update()
    {
	   // Debug.Log("slider: " +  mySlider.value);
        
    }
}
