[ComVisibleAttribute] // RVA: 0xAE2E0 Offset: 0xAE3E1 VA: 0xAE2E0
[ComDefaultInterfaceAttribute] // RVA: 0xAE2E0 Offset: 0xAE3E1 VA: 0xAE2E0
[ClassInterfaceAttribute] // RVA: 0xAE2E0 Offset: 0xAE3E1 VA: 0xAE2E0
[Serializable]
public abstract class FieldInfo : MemberInfo, _FieldInfo // TypeDefIndex: 580
{
	// Properties
	public abstract FieldAttributes Attributes { get; }
	public abstract RuntimeFieldHandle FieldHandle { get; }
	public abstract Type FieldType { get; }
	public override MemberTypes MemberType { get; }
	public bool IsLiteral { get; }
	public bool IsStatic { get; }
	public bool IsInitOnly { get; }
	public bool IsPublic { get; }
	public bool IsPrivate { get; }
	public bool IsFamily { get; }
	public bool IsNotSerialized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract FieldAttributes get_Attributes() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x1967D50 Offset: 0x1967E51 VA: 0x1967D50
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Type get_FieldType() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract object GetValue(object obj) { }

	// RVA: 0x1967D60 Offset: 0x1967E61 VA: 0x1967D60 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1967D70 Offset: 0x1967E71 VA: 0x1967D70 Slot: 20
	public bool get_IsLiteral() { }

	// RVA: 0x1967DA0 Offset: 0x1967EA1 VA: 0x1967DA0 Slot: 21
	public bool get_IsStatic() { }

	// RVA: 0x1967DD0 Offset: 0x1967ED1 VA: 0x1967DD0 Slot: 22
	public bool get_IsInitOnly() { }

	// RVA: 0x1967E00 Offset: 0x1967F01 VA: 0x1967E00 Slot: 23
	public bool get_IsPublic() { }

	// RVA: 0x1967E30 Offset: 0x1967F31 VA: 0x1967E30 Slot: 24
	public bool get_IsPrivate() { }

	// RVA: 0x1967E60 Offset: 0x1967F61 VA: 0x1967E60 Slot: 25
	public bool get_IsFamily() { }

	// RVA: 0x1967E90 Offset: 0x1967F91 VA: 0x1967E90 Slot: 26
	public bool get_IsNotSerialized() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[DebuggerStepThroughAttribute] // RVA: 0xB82D0 Offset: 0xB83D1 VA: 0xB82D0
	[DebuggerHiddenAttribute] // RVA: 0xB82D0 Offset: 0xB83D1 VA: 0xB82D0
	// RVA: 0x1967EC0 Offset: 0x1967FC1 VA: 0x1967EC0 Slot: 28
	public void SetValue(object obj, object value) { }

	// RVA: 0x1967EE0 Offset: 0x1967FE1 VA: 0x1967EE0
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x1967EF0 Offset: 0x1967FF1 VA: 0x1967EF0
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisibleAttribute] // RVA: 0xB8310 Offset: 0xB8411 VA: 0xB8310
	// RVA: 0x1967F90 Offset: 0x1968091 VA: 0x1967F90
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x19680B0 Offset: 0x19681B1 VA: 0x19680B0 Slot: 29
	internal virtual int GetFieldOffset() { }

	[CLSCompliantAttribute] // RVA: 0xB8330 Offset: 0xB8431 VA: 0xB8330
	// RVA: 0x1968120 Offset: 0x1968221 VA: 0x1968120 Slot: 30
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x19681A0 Offset: 0x19682A1 VA: 0x19681A0
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x19681B0 Offset: 0x19682B1 VA: 0x19681B0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x19683E0 Offset: 0x19684E1 VA: 0x19683E0 Slot: 31
	public virtual object GetRawConstantValue() { }

	// RVA: 0x1968450 Offset: 0x1968551 VA: 0x1968450 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1968460 Offset: 0x1968561 VA: 0x1968460 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1968060 Offset: 0x1968161 VA: 0x1968060
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x1968470 Offset: 0x1968571 VA: 0x1968470
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }
}

