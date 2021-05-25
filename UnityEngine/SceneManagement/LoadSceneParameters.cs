[Serializable]
public struct LoadSceneParameters // TypeDefIndex: 3125
{
	// Fields
	[SerializeField] // RVA: 0xCB340 Offset: 0xCB441 VA: 0xCB340
	private LoadSceneMode m_LoadSceneMode; // 0x0
	[SerializeField] // RVA: 0xCB350 Offset: 0xCB451 VA: 0xCB350
	private LocalPhysicsMode m_LocalPhysicsMode; // 0x4

	// Properties
	public LoadSceneMode loadSceneMode { set; }

	// Methods

	// RVA: 0x374F10 Offset: 0x375011 VA: 0x374F10
	public void set_loadSceneMode(LoadSceneMode value) { }

	// RVA: 0x374F20 Offset: 0x375021 VA: 0x374F20
	public void .ctor(LoadSceneMode mode) { }
}

