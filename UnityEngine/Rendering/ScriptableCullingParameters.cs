[UsedByNativeCodeAttribute] // RVA: 0xC89C0 Offset: 0xC8AC1 VA: 0xC89C0
public struct ScriptableCullingParameters : IEquatable<ScriptableCullingParameters> // TypeDefIndex: 3321
{
	// Fields
	private int m_IsOrthographic; // 0x0
	private LODParameters m_LODParameters; // 0x4
	public static readonly int maximumCullingPlaneCount; // 0x0
	[FixedBufferAttribute] // RVA: 0xCB9D0 Offset: 0xCBAD1 VA: 0xCB9D0
	internal ScriptableCullingParameters.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x20
	private int m_CullingPlaneCount; // 0xC0
	private uint m_CullingMask; // 0xC4
	private ulong m_SceneMask; // 0xC8
	public static readonly int layerCount; // 0x4
	[FixedBufferAttribute] // RVA: 0xCBA40 Offset: 0xCBB41 VA: 0xCBA40
	internal ScriptableCullingParameters.<m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances; // 0xD0
	private int m_LayerCull; // 0x150
	private Matrix4x4 m_CullingMatrix; // 0x154
	private Vector3 m_Origin; // 0x194
	private float m_ShadowDistance; // 0x1A0
	private CullingOptions m_CullingOptions; // 0x1A4
	private ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria; // 0x1A8
	private CameraProperties m_CameraProperties; // 0x1AC
	private float m_AccurateOcclusionThreshold; // 0x590
	private int m_MaximumPortalCullingJobs; // 0x594
	private Matrix4x4 m_StereoViewMatrix; // 0x598
	private Matrix4x4 m_StereoProjectionMatrix; // 0x5D8
	private float m_StereoSeparationDistance; // 0x618
	private int m_maximumVisibleLights; // 0x61C

	// Properties
	public int cullingPlaneCount { get; }

	// Methods

	// RVA: 0x3745A0 Offset: 0x3746A1 VA: 0x3745A0
	public int get_cullingPlaneCount() { }

	// RVA: 0x3745B0 Offset: 0x3746B1 VA: 0x3745B0
	public float GetLayerCullingDistance(int layerIndex) { }

	// RVA: 0x3745C0 Offset: 0x3746C1 VA: 0x3745C0
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x3745D0 Offset: 0x3746D1 VA: 0x3745D0 Slot: 4
	public bool Equals(ScriptableCullingParameters other) { }

	// RVA: 0x374610 Offset: 0x374711 VA: 0x374610 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3746C0 Offset: 0x3747C1 VA: 0x3746C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A221E0 Offset: 0x2A222E1 VA: 0x2A221E0
	private static void .cctor() { }
}

