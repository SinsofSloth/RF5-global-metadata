[ClassInterfaceAttribute] // RVA: 0xADB30 Offset: 0xADC31 VA: 0xADB30
[ComVisibleAttribute] // RVA: 0xADB30 Offset: 0xADC31 VA: 0xADB30
[ComDefaultInterfaceAttribute] // RVA: 0xADB30 Offset: 0xADC31 VA: 0xADB30
[Serializable]
public abstract class MemberInfo : ICustomAttributeProvider, _MemberInfo // TypeDefIndex: 546
{
	// Properties
	public abstract MemberTypes MemberType { get; }
	public abstract string Name { get; }
	public abstract Type DeclaringType { get; }
	public abstract Type ReflectedType { get; }
	public virtual int MetadataToken { get; }
	public virtual Module Module { get; }

	// Methods

	// RVA: 0x1967410 Offset: 0x1967511 VA: 0x1967410
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Type get_DeclaringType() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_ReflectedType() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract object[] GetCustomAttributes(bool inherit) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1968CC0 Offset: 0x1968DC1 VA: 0x1968CC0 Slot: 13
	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x1968D20 Offset: 0x1968E21 VA: 0x1968D20 Slot: 14
	public virtual int get_MetadataToken() { }

	// RVA: 0x1968D30 Offset: 0x1968E31 VA: 0x1968D30 Slot: 15
	public virtual Module get_Module() { }

	// RVA: 0x195D8F0 Offset: 0x195D9F1 VA: 0x195D8F0
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x1969090 Offset: 0x1969191 VA: 0x1969090
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x19690B0 Offset: 0x19691B1 VA: 0x19690B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1967440 Offset: 0x1967541 VA: 0x1967440 Slot: 2
	public override int GetHashCode() { }
}

