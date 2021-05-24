[NativeHeaderAttribute] // RVA: 0x109450 Offset: 0x109551 VA: 0x109450
public struct NavMeshBuildSettings // TypeDefIndex: 3787
{
	// Fields
	private int m_AgentTypeID; // 0x0
	private float m_AgentRadius; // 0x4
	private float m_AgentHeight; // 0x8
	private float m_AgentSlope; // 0xC
	private float m_AgentClimb; // 0x10
	private float m_LedgeDropHeight; // 0x14
	private float m_MaxJumpAcrossDistance; // 0x18
	private float m_MinRegionArea; // 0x1C
	private int m_OverrideVoxelSize; // 0x20
	private float m_VoxelSize; // 0x24
	private int m_OverrideTileSize; // 0x28
	private int m_TileSize; // 0x2C
	private int m_AccuratePlacement; // 0x30
	private NavMeshBuildDebugSettings m_Debug; // 0x34

	// Properties
	public int agentTypeID { get; set; }
	public bool overrideVoxelSize { set; }
	public float voxelSize { set; }
	public bool overrideTileSize { set; }
	public int tileSize { set; }

	// Methods

	// RVA: 0x22D60 Offset: 0x22E61 VA: 0x22D60
	public int get_agentTypeID() { }

	// RVA: 0x22D70 Offset: 0x22E71 VA: 0x22D70
	public void set_agentTypeID(int value) { }

	// RVA: 0x22D80 Offset: 0x22E81 VA: 0x22D80
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0x22D90 Offset: 0x22E91 VA: 0x22D90
	public void set_voxelSize(float value) { }

	// RVA: 0x22DA0 Offset: 0x22EA1 VA: 0x22DA0
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x22DB0 Offset: 0x22EB1 VA: 0x22DB0
	public void set_tileSize(int value) { }
}

