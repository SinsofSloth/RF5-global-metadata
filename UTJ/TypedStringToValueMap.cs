[DefaultMemberAttribute] // RVA: 0x147B50 Offset: 0x147C51 VA: 0x147B50
public class TypedStringToValueMap // TypeDefIndex: 9178
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x177540 Offset: 0x177641 VA: 0x177540
	private Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x177550 Offset: 0x177651 VA: 0x177550
	private object <DefaultValue>k__BackingField; // 0x18
	private Dictionary<string, object> map; // 0x20

	// Properties
	public Type Type { get; set; }
	public object DefaultValue { get; set; }
	public object Item { get; }

	// Methods

	// RVA: 0x23A7000 Offset: 0x23A7101 VA: 0x23A7000
	public void .ctor(Type inputType, Dictionary<string, object> inputMap, object inputDefaultValue) { }

	// RVA: -1 Offset: -1
	public static TypedStringToValueMap Create<T>(Dictionary<string, T> inputMap, T inputDefaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F8140 Offset: 0x34F8241 VA: 0x34F8140
	|-TypedStringToValueMap.Create<object>
	*/

	// RVA: -1 Offset: -1
	public static TypedStringToValueMap Create<T>(Dictionary<string, T> inputMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F7D30 Offset: 0x34F7E31 VA: 0x34F7D30
	|-TypedStringToValueMap.Create<object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x1A97A0 Offset: 0x1A98A1 VA: 0x1A97A0
	// RVA: 0x23A7070 Offset: 0x23A7171 VA: 0x23A7070
	public Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A97B0 Offset: 0x1A98B1 VA: 0x1A97B0
	// RVA: 0x23A7080 Offset: 0x23A7181 VA: 0x23A7080
	private void set_Type(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A97C0 Offset: 0x1A98C1 VA: 0x1A97C0
	// RVA: 0x23A7090 Offset: 0x23A7191 VA: 0x23A7090
	public object get_DefaultValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A97D0 Offset: 0x1A98D1 VA: 0x1A97D0
	// RVA: 0x23A70A0 Offset: 0x23A71A1 VA: 0x23A70A0
	private void set_DefaultValue(object value) { }

	// RVA: 0x23A4C90 Offset: 0x23A4D91 VA: 0x23A4C90
	public object get_Item(string key) { }

	// RVA: 0x23A70B0 Offset: 0x23A71B1 VA: 0x23A70B0
	public string GetKey(object value) { }
}

