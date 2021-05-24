public static class SRReflection // TypeDefIndex: 4362
{
	// Methods

	// RVA: 0x1A7DB00 Offset: 0x1A7DC01 VA: 0x1A7DB00
	public static void SetPropertyValue(object obj, PropertyInfo p, object value) { }

	// RVA: 0x1A7DA10 Offset: 0x1A7DB11 VA: 0x1A7DA10
	public static object GetPropertyValue(object obj, PropertyInfo p) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(MemberInfo t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C6740 Offset: 0x23C6841 VA: 0x23C6740
	|-SRReflection.GetAttribute<SortAttribute>
	|-SRReflection.GetAttribute<CategoryAttribute>
	|-SRReflection.GetAttribute<DisplayNameAttribute>
	|-SRReflection.GetAttribute<ImportAttribute>
	|-SRReflection.GetAttribute<RequiredFieldAttribute>
	|-SRReflection.GetAttribute<ServiceAttribute>
	|-SRReflection.GetAttribute<ServiceConstructorAttribute>
	|-SRReflection.GetAttribute<ServiceSelectorAttribute>
	|-SRReflection.GetAttribute<object>
	*/
}

