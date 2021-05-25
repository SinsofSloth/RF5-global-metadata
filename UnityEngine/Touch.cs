[NativeHeaderAttribute] // RVA: 0xF9800 Offset: 0xF9901 VA: 0xF9800
public struct Touch // TypeDefIndex: 3631
{
	// Fields
	private int m_FingerId; // 0x0
	private Vector2 m_Position; // 0x4
	private Vector2 m_RawPosition; // 0xC
	private Vector2 m_PositionDelta; // 0x14
	private float m_TimeDelta; // 0x1C
	private int m_TapCount; // 0x20
	private TouchPhase m_Phase; // 0x24
	private TouchType m_Type; // 0x28
	private float m_Pressure; // 0x2C
	private float m_maximumPossiblePressure; // 0x30
	private float m_Radius; // 0x34
	private float m_RadiusVariance; // 0x38
	private float m_AltitudeAngle; // 0x3C
	private float m_AzimuthAngle; // 0x40

	// Properties
	public int fingerId { get; }
	public Vector2 position { get; }
	public Vector2 deltaPosition { get; }
	public TouchPhase phase { get; }
	public TouchType type { get; }

	// Methods

	// RVA: 0x26D80 Offset: 0x26E81 VA: 0x26D80
	public int get_fingerId() { }

	// RVA: 0x26D90 Offset: 0x26E91 VA: 0x26D90
	public Vector2 get_position() { }

	// RVA: 0x26DA0 Offset: 0x26EA1 VA: 0x26DA0
	public Vector2 get_deltaPosition() { }

	// RVA: 0x26DB0 Offset: 0x26EB1 VA: 0x26DB0
	public TouchPhase get_phase() { }

	// RVA: 0x26DC0 Offset: 0x26EC1 VA: 0x26DC0
	public TouchType get_type() { }
}

