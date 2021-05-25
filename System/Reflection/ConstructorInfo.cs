[ComVisibleAttribute] // RVA: 0xAE120 Offset: 0xAE221 VA: 0xAE120
[ClassInterfaceAttribute] // RVA: 0xAE120 Offset: 0xAE221 VA: 0xAE120
[ComDefaultInterfaceAttribute] // RVA: 0xAE120 Offset: 0xAE221 VA: 0xAE120
[Serializable]
public abstract class ConstructorInfo : MethodBase, _ConstructorInfo // TypeDefIndex: 571
{
	// Fields
	[ComVisibleAttribute] // RVA: 0xB47F0 Offset: 0xB48F1 VA: 0xB47F0
	public static readonly string ConstructorName; // 0x0
	[ComVisibleAttribute] // RVA: 0xB4810 Offset: 0xB4911 VA: 0xB4810
	public static readonly string TypeConstructorName; // 0x8

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA130 Offset: 0xBA231 VA: 0xBA130
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x195BAD0 Offset: 0x195BBD1 VA: 0x195BAD0
	protected void .ctor() { }

	// RVA: 0x195BAF0 Offset: 0x195BBF1 VA: 0x195BAF0 Slot: 6
	public override MemberTypes get_MemberType() { }

	[DebuggerHiddenAttribute] // RVA: 0xB8290 Offset: 0xB8391 VA: 0xB8290
	[DebuggerStepThroughAttribute] // RVA: 0xB8290 Offset: 0xB8391 VA: 0xB8290
	// RVA: 0x195BB00 Offset: 0x195BC01 VA: 0x195BB00
	public object Invoke(object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x195BBC0 Offset: 0x195BCC1 VA: 0x195BBC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x195BBD0 Offset: 0x195BCD1 VA: 0x195BBD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x195BBF0 Offset: 0x195BCF1 VA: 0x195BBF0
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x195BC40 Offset: 0x195BD41 VA: 0x195BC40
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x195BCB0 Offset: 0x195BDB1 VA: 0x195BCB0
	private static void .cctor() { }
}

