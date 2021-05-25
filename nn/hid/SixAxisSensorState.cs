public struct SixAxisSensorState // TypeDefIndex: 11586
{
	// Fields
	public const float AccelerometerMax = 7;
	public const float AngularVelocityMax = 5;
	public long deltaTimeNanoSeconds; // 0x0
	public long samplingNumber; // 0x8
	public Float3 acceleration; // 0x10
	public Float3 angularVelocity; // 0x1C
	public Float3 angle; // 0x28
	public DirectionState direction; // 0x34
	public SixAxisSensorAttribute attributes; // 0x58

	// Methods

	// RVA: 0x385690 Offset: 0x385791 VA: 0x385690 Slot: 3
	public override string ToString() { }

	// RVA: 0x3856A0 Offset: 0x3857A1 VA: 0x3856A0
	public void GetQuaternion(ref float x, ref float y, ref float z, ref float w) { }

	// RVA: 0x3856B0 Offset: 0x3857B1 VA: 0x3856B0
	public void GetQuaternion(ref Float4 quaternion) { }

	// RVA: 0x2C640F0 Offset: 0x2C641F1 VA: 0x2C640F0
	private static extern void GetQuaternion(ref SixAxisSensorState state, ref float pOutX, ref float pOutY, ref float pOutZ, ref float pOutW) { }
}

