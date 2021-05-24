internal abstract class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 604
{
	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x17F2010 Offset: 0x17F2111 VA: 0x17F2010
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x17F2020 Offset: 0x17F2121 VA: 0x17F2020 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x17F2160 Offset: 0x17F2261 VA: 0x17F2160
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x17F21F0 Offset: 0x17F22F1 VA: 0x17F21F0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x17F20C0 Offset: 0x17F21C1 VA: 0x17F20C0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x17F2280 Offset: 0x17F2381 VA: 0x17F2280 Slot: 3
	public override string ToString() { }

	// RVA: 0x17F2290 Offset: 0x17F2391 VA: 0x17F2290
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x17F23E0 Offset: 0x17F24E1 VA: 0x17F23E0 Slot: 36
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F2540 Offset: 0x17F2641 VA: 0x17F2540
	internal string SerializationToString() { }

	// RVA: 0x17EEC20 Offset: 0x17EED21 VA: 0x17EEC20
	protected void .ctor() { }
}

