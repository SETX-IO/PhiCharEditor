using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace SETSVPC.Toolkit {
	public class Toolkit : EditorWindow {
		[MenuItem("Project Toolkit/Toolkit")]
		public static void ShowExample() {
			var wnd = GetWindow<Toolkit>();
			wnd.titleContent = new("Toolkit");
		}

		public void CreateGUI() {
			var root = rootVisualElement;

			var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/Toolkit.uxml");
			VisualElement labelFromUXML = visualTree.Instantiate();
			root.Add(labelFromUXML);
		}

		private void OnDestroy() => Debug.Log("Windows Close");
	}
}