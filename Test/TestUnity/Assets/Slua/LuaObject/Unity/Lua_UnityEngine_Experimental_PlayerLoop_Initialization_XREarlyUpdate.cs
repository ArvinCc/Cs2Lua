﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_PlayerLoop_Initialization_XREarlyUpdate : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.PlayerLoop.Initialization.XREarlyUpdate o;
			o=new UnityEngine.Experimental.PlayerLoop.Initialization.XREarlyUpdate();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.PlayerLoop.Initialization.XREarlyUpdate");
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.PlayerLoop.Initialization.XREarlyUpdate),typeof(System.ValueType));
	}
}
