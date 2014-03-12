/*

Initial code from tutorial at http://code.tutsplus.com/tutorials/how-to-add-your-own-tools-to-unitys-editor--active-10047

I've followed this excellent editor extension tutorial to get a start on tile-based editing in Unity. Making tweaks as
needed along the way.  

*/

using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

    public float width = 10.0f;
    public float height = 10.0f;

	public Color color = Color.white;

	public bool isVisible = true;

    private const float MinGridSpace = 1.0f;

    void OnDrawGizmos() {
        Vector3 pos = Camera.current.transform.position;
		Gizmos.color = color;

        // Ensure no division by zero, causing infinite grid lines and crashing unity
        if (width < MinGridSpace) width = MinGridSpace;
        if (height < MinGridSpace) height = MinGridSpace;

        for (float y = pos.y - 800.0f; y < pos.y + 800.0f; y += height) {
            Gizmos.DrawLine(new Vector3(-1000000.0f, Mathf.Floor(y / height) * height, 0.0f),
                new Vector3(1000000.0f, Mathf.Floor(y / height) * height, 0.0f));
        }
        for (float x = pos.x - 1200.0f; x < pos.x + 1200.0f; x += width) {
            Gizmos.DrawLine(new Vector3(Mathf.Floor(x / width) * width, -1000000.0f, 0.0f),
                new Vector3(Mathf.Floor(x / width) * width, 1000000.0f, 0.0f));
        }

    }
}
