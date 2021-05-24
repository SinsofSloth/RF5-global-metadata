[ClassInterfaceAttribute] // RVA: 0xAE6B0 Offset: 0xAE7B1 VA: 0xAE6B0
[ComDefaultInterfaceAttribute] // RVA: 0xAE6B0 Offset: 0xAE7B1 VA: 0xAE6B0
[ComVisibleAttribute] // RVA: 0xAE6B0 Offset: 0xAE7B1 VA: 0xAE6B0
[Serializable]
public abstract class PropertyInfo : MemberInfo, _PropertyInfo // TypeDefIndex: 610
{
	// Properties
	public abstract PropertyAttributes Attributes { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public virtual MethodInfo GetMethod { get; }
	public virtual MethodInfo SetMethod { get; }
	public override MemberTypes MemberType { get; }
	public abstract Type PropertyType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract PropertyAttributes get_Attributes() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_CanRead() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_CanWrite() { }

	// RVA: 0x17EFE30 Offset: 0x17EFF31 VA: 0x17EFE30 Slot: 19
	public virtual MethodInfo get_GetMethod() { }

	// RVA: 0x17EFE50 Offset: 0x17EFF51 VA: 0x17EFE50 Slot: 20
	public virtual MethodInfo get_SetMethod() { }

	// RVA: 0x17EFE70 Offset: 0x17EFF71 VA: 0x17EFE70 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract Type get_PropertyType() { }

	// RVA: 0x17EFE80 Offset: 0x17EFF81 VA: 0x17EFE80
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x17EFE90 Offset: 0x17EFF91 VA: 0x17EFE90 Slot: 23
	public MethodInfo GetGetMethod() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x17EFEB0 Offset: 0x17EFFB1 VA: 0x17EFEB0 Slot: 26
	public MethodInfo GetSetMethod() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract MethodInfo GetSetMethod(bool nonPublic) { }

	[DebuggerHiddenAttribute] // RVA: 0xB8490 Offset: 0xB8591 VA: 0xB8490
	[DebuggerStepThroughAttribute] // RVA: 0xB8490 Offset: 0xB8591 VA: 0xB8490
	// RVA: 0x17EFED0 Offset: 0x17EFFD1 VA: 0x17EFED0 Slot: 28
	public virtual object GetValue(object obj, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	[DebuggerStepThroughAttribute] // RVA: 0xB84D0 Offset: 0xB85D1 VA: 0xB84D0
	[DebuggerHiddenAttribute] // RVA: 0xB84D0 Offset: 0xB85D1 VA: 0xB84D0
	// RVA: 0x17EFEF0 Offset: 0x17EFFF1 VA: 0x17EFEF0 Slot: 30
	public virtual void SetValue(object obj, object value, object[] index) { }

	[DebuggerStepThroughAttribute] // RVA: 0xB8510 Offset: 0xB8611 VA: 0xB8510
	[DebuggerHiddenAttribute] // RVA: 0xB8510 Offset: 0xB8611 VA: 0xB8510
	// RVA: 0x17EFF10 Offset: 0x17F0011 VA: 0x17EFF10
	public void SetValue(object obj, object value) { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EFF30 Offset: 0x17F0031 VA: 0x17EFF30 Slot: 32
	public virtual Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x17EFFA0 Offset: 0x17F00A1 VA: 0x17EFFA0 Slot: 33
	public virtual Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x17F0010 Offset: 0x17F0111 VA: 0x17F0010
	private static NotImplementedException CreateNIE() { }

	// RVA: 0x17F0070 Offset: 0x17F0171 VA: 0x17F0070 Slot: 34
	public virtual object GetConstantValue() { }

	// RVA: 0x17F00C0 Offset: 0x17F01C1 VA: 0x17F00C0 Slot: 35
	public virtual object GetRawConstantValue() { }

	// RVA: 0x17F0110 Offset: 0x17F0211 VA: 0x17F0110 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17F0120 Offset: 0x17F0221 VA: 0x17F0120 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17F0130 Offset: 0x17F0231 VA: 0x17F0130
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x17F0180 Offset: 0x17F0281 VA: 0x17F0180
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x17F01F0 Offset: 0x17F02F1 VA: 0x17F01F0
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x17F0200 Offset: 0x17F0301 VA: 0x17F0200
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }
}

