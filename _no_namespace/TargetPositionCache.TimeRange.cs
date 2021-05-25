public struct TargetPositionCache.TimeRange // TypeDefIndex: 4866
{
	// Fields
	public float Start; // 0x0
	public float End; // 0x4

	// Properties
	public bool IsEmpty { get; }
	public static TargetPositionCache.TimeRange Empty { get; }

	// Methods

	// RVA: 0x17E00 Offset: 0x17F01 VA: 0x17E00
	public bool get_IsEmpty() { }

	// RVA: 0x17E10 Offset: 0x17F11 VA: 0x17E10
	public bool Contains(float time) { }

	// RVA: 0x1A20690 Offset: 0x1A20791 VA: 0x1A20690
	public static TargetPositionCache.TimeRange get_Empty() { }

	// RVA: 0x17E40 Offset: 0x17F41 VA: 0x17E40
	public void Include(float time) { }
}

