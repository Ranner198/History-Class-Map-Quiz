using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanAndZoom : MonoBehaviour {

	//Pan Camera
	public float mouseSensitivity = 1;
	private Vector3 lastPosition;

	//Scroll Wheel / Zoom Lock
	public float minZ = 15f;
	public float maxZ = 90f;
	public float Sensitivity;

    //Pan Lock
    private float Horz, Vert, minX, maxX, minY, maxY;
    public SpriteRenderer SR;

    void Start()
    {
        Vert = Camera.main.orthographicSize;
        Horz = Vert *  Screen.width/Screen.height;



        minX = Vert - SR.sprite.bounds.size.y / 2.0f;
        maxX = SR.sprite.bounds.size.y / 2.0f - Vert;

        minY = Vert - SR.sprite.bounds.size.y / 2.0f;
        maxY = SR.sprite.bounds.size.y / 2.0f - Vert;
    }

	void LateUpdate()
	{
        //Middle Mouse Button Position
        if (Input.GetMouseButtonDown(2))
		{
			lastPosition = Input.mousePosition;
		}

		if (Input.GetMouseButton(2))
		{
			 Vector3 Pos = Input.mousePosition - lastPosition;
			transform.Translate(-Pos.x * mouseSensitivity, - Pos.y * mouseSensitivity, 0);
			lastPosition = Input.mousePosition;
		}

        Vector3 _myPos = transform.position;
        _myPos.x = Mathf.Clamp(_myPos.x, minX, maxX);
        _myPos.y = Mathf.Clamp(_myPos.y, minY, maxY);
        transform.position = _myPos;

        //Scroll Wheel Zoom
        float fov = Camera.main.fieldOfView;
		fov += Input.GetAxis ("Mouse ScrollWheel") * -Sensitivity;
		fov = Mathf.Clamp(fov, minZ, maxZ);
		Camera.main.fieldOfView = fov;
	}
}
