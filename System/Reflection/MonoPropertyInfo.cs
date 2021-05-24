internal struct MonoPropertyInfo // TypeDefIndex: 602
{
	// Fields
	public Type parent; // 0x0
	public Type declaring_type; // 0x8
	public string name; // 0x10
	public MethodInfo get_method; // 0x18
	public MethodInfo set_method; // 0x20
	public PropertyAttributes attrs; // 0x28

	// Methods

	// RVA: 0x17ED880 Offset: 0x17ED981 VA: 0x17ED880
	internal static void get_property_info(MonoProperty prop, ref MonoPropertyInfo info, PInfo req_info) { }

	// RVA: 0x17EEB50 Offset: 0x17EEC51 VA: 0x17EEB50
	internal static Type[] GetTypeModifiers(MonoProperty prop, bool optional) { }

	// RVA: 0x17EE100 Offset: 0x17EE201 VA: 0x17EE100
	internal static object get_default_value(MonoProperty prop) { }
}

