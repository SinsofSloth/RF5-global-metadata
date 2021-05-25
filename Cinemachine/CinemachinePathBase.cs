public abstract class CinemachinePathBase : MonoBehaviour // TypeDefIndex: 4833
{
	// Fields
	[TooltipAttribute] // RVA: 0x134860 Offset: 0x134961 VA: 0x134860
	[RangeAttribute] // RVA: 0x134860 Offset: 0x134961 VA: 0x134860
	public int m_Resolution; // 0x18
	[TooltipAttribute] // RVA: 0x1348C0 Offset: 0x1349C1 VA: 0x1348C0
	public CinemachinePathBase.Appearance m_Appearance; // 0x20
	private float[] m_DistanceToPos; // 0x28
	private float[] m_PosToDistance; // 0x30
	private int m_CachedSampleSteps; // 0x38
	private float m_PathLength; // 0x3C
	private float m_cachedPosStepSize; // 0x40
	private float m_cachedDistanceStepSize; // 0x44

	// Properties
	public abstract float MinPos { get; }
	public abstract float MaxPos { get; }
	public abstract bool Looped { get; }
	public abstract int DistanceCacheSampleStepsPerSegment { get; }
	public float PathLength { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_MinPos() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_MaxPos() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_Looped() { }

	// RVA: 0x1733610 Offset: 0x1733711 VA: 0x1733610 Slot: 7
	public virtual float StandardizePos(float pos) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Vector3 EvaluatePosition(float pos) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Vector3 EvaluateTangent(float pos) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Quaternion EvaluateOrientation(float pos) { }

	// RVA: 0x1733720 Offset: 0x1733821 VA: 0x1733720 Slot: 11
	public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment) { }

	// RVA: 0x1733A70 Offset: 0x1733B71 VA: 0x1733A70
	public float MinUnit(CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1733A90 Offset: 0x1733B91 VA: 0x1733A90
	public float MaxUnit(CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1733C90 Offset: 0x1733D91 VA: 0x1733C90 Slot: 12
	public virtual float StandardizeUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1720BF0 Offset: 0x1720CF1 VA: 0x1720BF0
	public Vector3 EvaluatePositionAtUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1734270 Offset: 0x1734371 VA: 0x1734270
	public Vector3 EvaluateTangentAtUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1720C20 Offset: 0x1720D21 VA: 0x1720C20
	public Quaternion EvaluateOrientationAtUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int get_DistanceCacheSampleStepsPerSegment() { }

	// RVA: 0x17342A0 Offset: 0x17343A1 VA: 0x17342A0 Slot: 14
	public virtual void InvalidateDistanceCache() { }

	// RVA: 0x17342E0 Offset: 0x17343E1 VA: 0x17342E0
	public bool DistanceCacheIsValid() { }

	// RVA: 0x1733BB0 Offset: 0x1733CB1 VA: 0x1733BB0
	public float get_PathLength() { }

	// RVA: 0x1733DE0 Offset: 0x1733EE1 VA: 0x1733DE0
	public float StandardizePathDistance(float distance) { }

	// RVA: 0x1733F60 Offset: 0x1734061 VA: 0x1733F60
	public float ToNativePathUnits(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x1734710 Offset: 0x1734811 VA: 0x1734710
	public float FromPathNativeUnits(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0x17343C0 Offset: 0x17344C1 VA: 0x17343C0
	private void ResamplePath(int stepsPerSegment) { }

	// RVA: 0x1733550 Offset: 0x1733651 VA: 0x1733550
	protected void .ctor() { }
}

