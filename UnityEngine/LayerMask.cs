[RequiredByNativeCodeAttribute] // RVA: 0xC6B30 Offset: 0xC6C31 VA: 0xC6B30
[NativeClassAttribute] // RVA: 0xC6B30 Offset: 0xC6C31 VA: 0xC6B30
[NativeHeaderAttribute] // RVA: 0xC6B30 Offset: 0xC6C31 VA: 0xC6B30
[NativeHeaderAttribute] // RVA: 0xC6B30 Offset: 0xC6C31 VA: 0xC6B30
public struct LayerMask // TypeDefIndex: 3015
{
	// Fields
	[NativeNameAttribute] // RVA: 0xCA870 Offset: 0xCA971 VA: 0xCA870
	private int m_Mask; // 0x0

	// Properties
	public int value { get; set; }

	// Methods

	// RVA: 0x1A2CC80 Offset: 0x1A2CD81 VA: 0x1A2CC80
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x1A2CC90 Offset: 0x1A2CD91 VA: 0x1A2CC90
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x18490 Offset: 0x18591 VA: 0x18490
	public int get_value() { }

	// RVA: 0x184A0 Offset: 0x185A1 VA: 0x184A0
	public void set_value(int value) { }

	[NativeMethodAttribute] // RVA: 0xD6BA0 Offset: 0xD6CA1 VA: 0xD6BA0
	[StaticAccessorAttribute] // RVA: 0xD6BA0 Offset: 0xD6CA1 VA: 0xD6BA0
	// RVA: 0x1A2CCC0 Offset: 0x1A2CDC1 VA: 0x1A2CCC0
	public static string LayerToName(int layer) { }

	[NativeMethodAttribute] // RVA: 0xD6C10 Offset: 0xD6D11 VA: 0xD6C10
	[StaticAccessorAttribute] // RVA: 0xD6C10 Offset: 0xD6D11 VA: 0xD6C10
	// RVA: 0x1A2CD10 Offset: 0x1A2CE11 VA: 0x1A2CD10
	public static int NameToLayer(string layerName) { }

	// RVA: 0x1A2CD60 Offset: 0x1A2CE61 VA: 0x1A2CD60
	public static int GetMask(string[] layerNames) { }
}

