internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 6
{
	// Fields
	private RuntimeStructs.GenericParamInfo* value; // 0x0

	// Properties
	internal Type[] Constraints { get; }
	internal GenericParameterAttributes Attributes { get; }

	// Methods

	// RVA: 0x114C0 Offset: 0x115C1 VA: 0x114C0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x114F0 Offset: 0x115F1 VA: 0x114F0
	internal Type[] get_Constraints() { }

	// RVA: 0x11500 Offset: 0x11601 VA: 0x11500
	internal GenericParameterAttributes get_Attributes() { }

	// RVA: 0x11520 Offset: 0x11621 VA: 0x11520
	private Type[] GetConstraints() { }

	// RVA: 0x11530 Offset: 0x11631 VA: 0x11530
	private int GetConstraintsCount() { }
}

