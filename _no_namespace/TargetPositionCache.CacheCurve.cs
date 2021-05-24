private class TargetPositionCache.CacheCurve // TypeDefIndex: 4862
{
	// Fields
	public float StartTime; // 0x10
	public float StepSize; // 0x14
	private List<TargetPositionCache.CacheCurve.Item> m_Cache; // 0x18

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x1A21010 Offset: 0x1A21111 VA: 0x1A21010
	public int get_Count() { }

	// RVA: 0x1A21060 Offset: 0x1A21161 VA: 0x1A21060
	public void .ctor(float startTime, float endTime, float stepSize) { }

	// RVA: 0x1A21150 Offset: 0x1A21251 VA: 0x1A21150
	public void Add(TargetPositionCache.CacheCurve.Item item) { }

	// RVA: 0x1A21200 Offset: 0x1A21301 VA: 0x1A21200
	public void AddUntil(TargetPositionCache.CacheCurve.Item item, float time, bool isCut) { }

	// RVA: 0x1A20DA0 Offset: 0x1A20EA1 VA: 0x1A20DA0
	public TargetPositionCache.CacheCurve.Item Evaluate(float time) { }
}

