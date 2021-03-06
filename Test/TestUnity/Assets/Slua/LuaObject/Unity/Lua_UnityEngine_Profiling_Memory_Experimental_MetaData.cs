﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Profiling_Memory_Experimental_MetaData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Profiling.Memory.Experimental.MetaData o;
			o=new UnityEngine.Profiling.Memory.Experimental.MetaData();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_content(IntPtr l) {
		try {
			UnityEngine.Profiling.Memory.Experimental.MetaData self=(UnityEngine.Profiling.Memory.Experimental.MetaData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.content);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_content(IntPtr l) {
		try {
			UnityEngine.Profiling.Memory.Experimental.MetaData self=(UnityEngine.Profiling.Memory.Experimental.MetaData)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.content=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_platform(IntPtr l) {
		try {
			UnityEngine.Profiling.Memory.Experimental.MetaData self=(UnityEngine.Profiling.Memory.Experimental.MetaData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.platform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_platform(IntPtr l) {
		try {
			UnityEngine.Profiling.Memory.Experimental.MetaData self=(UnityEngine.Profiling.Memory.Experimental.MetaData)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.platform=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_screenshot(IntPtr l) {
		try {
			UnityEngine.Profiling.Memory.Experimental.MetaData self=(UnityEngine.Profiling.Memory.Experimental.MetaData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.screenshot);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_screenshot(IntPtr l) {
		try {
			UnityEngine.Profiling.Memory.Experimental.MetaData self=(UnityEngine.Profiling.Memory.Experimental.MetaData)checkSelf(l);
			UnityEngine.Texture2D v;
			checkType(l,2,out v);
			self.screenshot=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Profiling.Memory.Experimental.MetaData");
		addMember(l,"content",get_content,set_content,true);
		addMember(l,"platform",get_platform,set_platform,true);
		addMember(l,"screenshot",get_screenshot,set_screenshot,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Profiling.Memory.Experimental.MetaData));
	}
}
