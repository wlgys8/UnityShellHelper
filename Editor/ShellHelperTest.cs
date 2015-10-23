using UnityEngine;
using System.Collections;
using UnityEditor;

public class ShellHelperTest  {


	[MenuItem("ShellHelperTest/ls")]
	public static void ls(){
#if UNITY_EDITOR_OSX
		ShellHelper.ShellRequest req = ShellHelper.ProcessCommand("ls","");
		req.onLog += delegate(int arg1, string arg2) {
			Debug.Log(arg2);
		}; 

#endif
	}
	[MenuItem("ShellHelperTest/dir")]
	public static void dir(){
		#if UNITY_EDITOR_WIN
		ShellHelper.ShellRequest req = ShellHelper.ProcessCommand("dir","");
		req.onLog += delegate(int arg1, string arg2) {
			Debug.Log(arg2);
		};
		
		#endif
	}

}
