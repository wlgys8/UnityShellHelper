# Attention

check new version of unity shell which has better api design :

https://github.com/wlgys8/UnityShell 


# UnityShellHelper

This helper is designed for excuting shell command in unity editor.
It will excute command with bash on osx & cmd.exe on win.

Just drag the folder to your unity project and it will work.


example:

		ShellHelper.ShellRequest req = ShellHelper.ProcessCommand("ls","");
		req.onLog += delegate(int logType, string log) {
			Debug.Log(arg2);
		}; 
		
		
