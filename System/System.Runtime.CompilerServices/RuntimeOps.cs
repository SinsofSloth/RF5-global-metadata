[EditorBrowsableAttribute] // RVA: 0xBEFA0 Offset: 0xBF0A1 VA: 0xBEFA0
[DebuggerStepThroughAttribute] // RVA: 0xBEFA0 Offset: 0xBF0A1 VA: 0xBEFA0
public static class RuntimeOps // TypeDefIndex: 2715
{
	// Methods

	[EditorBrowsableAttribute] // RVA: 0xC0F30 Offset: 0xC1031 VA: 0xC0F30
	[ObsoleteAttribute] // RVA: 0xC0F30 Offset: 0xC1031 VA: 0xC0F30
	// RVA: 0x1B58900 Offset: 0x1B58A01 VA: 0x1B58900
	public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value) { }

	[EditorBrowsableAttribute] // RVA: 0xC0F90 Offset: 0xC1091 VA: 0xC0F90
	[ObsoleteAttribute] // RVA: 0xC0F90 Offset: 0xC1091 VA: 0xC0F90
	// RVA: 0x1B58920 Offset: 0x1B58A21 VA: 0x1B58920
	public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase) { }

	[EditorBrowsableAttribute] // RVA: 0xC0FF0 Offset: 0xC10F1 VA: 0xC0FF0
	[ObsoleteAttribute] // RVA: 0xC0FF0 Offset: 0xC10F1 VA: 0xC0FF0
	// RVA: 0x1B58960 Offset: 0x1B58A61 VA: 0x1B58960
	public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase) { }

	[EditorBrowsableAttribute] // RVA: 0xC1050 Offset: 0xC1151 VA: 0xC1050
	[ObsoleteAttribute] // RVA: 0xC1050 Offset: 0xC1151 VA: 0xC1050
	// RVA: 0x1B58A10 Offset: 0x1B58B11 VA: 0x1B58A10
	public static bool ExpandoCheckVersion(ExpandoObject expando, object version) { }

	[ObsoleteAttribute] // RVA: 0xC10B0 Offset: 0xC11B1 VA: 0xC10B0
	[EditorBrowsableAttribute] // RVA: 0xC10B0 Offset: 0xC11B1 VA: 0xC10B0
	// RVA: 0x1B58A50 Offset: 0x1B58B51 VA: 0x1B58A50
	public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass) { }
}

