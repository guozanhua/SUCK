﻿/*

Initial code from tutorial at http://code.tutsplus.com/tutorials/how-to-add-your-own-tools-to-unitys-editor--active-10047

I've followed this excellent editor extension tutorial to get a start on tile-based editing in Unity. Making tweaks as
needed along the way.  

*/

using UnityEngine;
using UnityEditor;
using System.Collections;

public class GridWindow : EditorWindow {

	Grid grid;

	public void Init() {
		grid = (Grid)FindObjectOfType(typeof(Grid));
	}

	void OnGUI() {
		grid.color = EditorGUILayout.ColorField(grid.color, GUILayout.Width(200));
	}
}
