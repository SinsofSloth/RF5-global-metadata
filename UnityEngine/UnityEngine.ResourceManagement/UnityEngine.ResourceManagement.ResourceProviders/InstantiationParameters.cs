public struct InstantiationParameters // TypeDefIndex: 4483
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Quaternion m_Rotation; // 0xC
	private Transform m_Parent; // 0x20
	private bool m_InstantiateInWorldPosition; // 0x28
	private bool m_SetPositionRotation; // 0x29

	// Properties
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Transform Parent { get; }
	public bool InstantiateInWorldPosition { get; }
	public bool SetPositionRotation { get; }

	// Methods

	// RVA: 0x161D0 Offset: 0x162D1 VA: 0x161D0
	public Vector3 get_Position() { }

	// RVA: 0x161E0 Offset: 0x162E1 VA: 0x161E0
	public Quaternion get_Rotation() { }

	// RVA: 0x161F0 Offset: 0x162F1 VA: 0x161F0
	public Transform get_Parent() { }

	// RVA: 0x16200 Offset: 0x16301 VA: 0x16200
	public bool get_InstantiateInWorldPosition() { }

	// RVA: 0x16210 Offset: 0x16311 VA: 0x16210
	public bool get_SetPositionRotation() { }

	// RVA: 0x16220 Offset: 0x16321 VA: 0x16220
	public void .ctor(Transform parent, bool instantiateInWorldSpace) { }

	// RVA: 0x16230 Offset: 0x16331 VA: 0x16230
	public void .ctor(Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: -1 Offset: -1
	public TObject Instantiate<TObject>(TObject source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F1E70 Offset: 0x2F1F71 VA: 0x2F1E70
	|-InstantiationParameters.Instantiate<object>
	|-InstantiationParameters.Instantiate<GameObject>
	*/
}

