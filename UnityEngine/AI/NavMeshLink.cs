[ExecuteInEditMode] // RVA: 0x140CA0 Offset: 0x140DA1 VA: 0x140CA0
[DefaultExecutionOrder] // RVA: 0x140CA0 Offset: 0x140DA1 VA: 0x140CA0
[AddComponentMenu] // RVA: 0x140CA0 Offset: 0x140DA1 VA: 0x140CA0
[HelpURLAttribute] // RVA: 0x140CA0 Offset: 0x140DA1 VA: 0x140CA0
public class NavMeshLink : MonoBehaviour // TypeDefIndex: 5915
{
	// Fields
	[SerializeField] // RVA: 0x140ED0 Offset: 0x140FD1 VA: 0x140ED0
	private int m_AgentTypeID; // 0x18
	[SerializeField] // RVA: 0x140EE0 Offset: 0x140FE1 VA: 0x140EE0
	private Vector3 m_StartPoint; // 0x1C
	[SerializeField] // RVA: 0x140EF0 Offset: 0x140FF1 VA: 0x140EF0
	private Vector3 m_EndPoint; // 0x28
	[SerializeField] // RVA: 0x140F00 Offset: 0x141001 VA: 0x140F00
	private float m_Width; // 0x34
	[SerializeField] // RVA: 0x140F10 Offset: 0x141011 VA: 0x140F10
	private int m_CostModifier; // 0x38
	[SerializeField] // RVA: 0x140F20 Offset: 0x141021 VA: 0x140F20
	private bool m_Bidirectional; // 0x3C
	[SerializeField] // RVA: 0x140F30 Offset: 0x141031 VA: 0x140F30
	private bool m_AutoUpdatePosition; // 0x3D
	[SerializeField] // RVA: 0x140F40 Offset: 0x141041 VA: 0x140F40
	private int m_Area; // 0x40
	private NavMeshLinkInstance m_LinkInstance; // 0x44
	private Vector3 m_LastPosition; // 0x48
	private Quaternion m_LastRotation; // 0x54
	private static readonly List<NavMeshLink> s_Tracked; // 0x0

	// Properties
	public int agentTypeID { get; set; }
	public Vector3 startPoint { get; set; }
	public Vector3 endPoint { get; set; }
	public float width { get; set; }
	public int costModifier { get; set; }
	public bool bidirectional { get; set; }
	public bool autoUpdate { get; set; }
	public int area { get; set; }

	// Methods

	// RVA: 0x1BA6310 Offset: 0x1BA6411 VA: 0x1BA6310
	public int get_agentTypeID() { }

	// RVA: 0x1BA6320 Offset: 0x1BA6421 VA: 0x1BA6320
	public void set_agentTypeID(int value) { }

	// RVA: 0x1BA6380 Offset: 0x1BA6481 VA: 0x1BA6380
	public Vector3 get_startPoint() { }

	// RVA: 0x1BA6390 Offset: 0x1BA6491 VA: 0x1BA6390
	public void set_startPoint(Vector3 value) { }

	// RVA: 0x1BA63D0 Offset: 0x1BA64D1 VA: 0x1BA63D0
	public Vector3 get_endPoint() { }

	// RVA: 0x1BA63E0 Offset: 0x1BA64E1 VA: 0x1BA63E0
	public void set_endPoint(Vector3 value) { }

	// RVA: 0x1BA6420 Offset: 0x1BA6521 VA: 0x1BA6420
	public float get_width() { }

	// RVA: 0x1BA6430 Offset: 0x1BA6531 VA: 0x1BA6430
	public void set_width(float value) { }

	// RVA: 0x1BA6460 Offset: 0x1BA6561 VA: 0x1BA6460
	public int get_costModifier() { }

	// RVA: 0x1BA6470 Offset: 0x1BA6571 VA: 0x1BA6470
	public void set_costModifier(int value) { }

	// RVA: 0x1BA64A0 Offset: 0x1BA65A1 VA: 0x1BA64A0
	public bool get_bidirectional() { }

	// RVA: 0x1BA64B0 Offset: 0x1BA65B1 VA: 0x1BA64B0
	public void set_bidirectional(bool value) { }

	// RVA: 0x1BA64F0 Offset: 0x1BA65F1 VA: 0x1BA64F0
	public bool get_autoUpdate() { }

	// RVA: 0x1BA6500 Offset: 0x1BA6601 VA: 0x1BA6500
	public void set_autoUpdate(bool value) { }

	// RVA: 0x1BA65E0 Offset: 0x1BA66E1 VA: 0x1BA65E0
	public int get_area() { }

	// RVA: 0x1BA65F0 Offset: 0x1BA66F1 VA: 0x1BA65F0
	public void set_area(int value) { }

	// RVA: 0x1BA6620 Offset: 0x1BA6721 VA: 0x1BA6620
	private void OnEnable() { }

	// RVA: 0x1BA6A00 Offset: 0x1BA6B01 VA: 0x1BA6A00
	private void OnDisable() { }

	// RVA: 0x1BA6350 Offset: 0x1BA6451 VA: 0x1BA6350
	public void UpdateLink() { }

	// RVA: 0x1BA68A0 Offset: 0x1BA69A1 VA: 0x1BA68A0
	private static void AddTracking(NavMeshLink link) { }

	// RVA: 0x1BA6A70 Offset: 0x1BA6B71 VA: 0x1BA6A70
	private static void RemoveTracking(NavMeshLink link) { }

	// RVA: 0x1BA6510 Offset: 0x1BA6611 VA: 0x1BA6510
	private void SetAutoUpdate(bool value) { }

	// RVA: 0x1BA66C0 Offset: 0x1BA67C1 VA: 0x1BA66C0
	private void AddLink() { }

	// RVA: 0x1BA6BB0 Offset: 0x1BA6CB1 VA: 0x1BA6BB0
	private bool HasTransformChanged() { }

	// RVA: 0x1BA6D20 Offset: 0x1BA6E21 VA: 0x1BA6D20
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x1BA6D50 Offset: 0x1BA6E51 VA: 0x1BA6D50
	private static void UpdateTrackedInstances() { }

	// RVA: 0x1BA6EA0 Offset: 0x1BA6FA1 VA: 0x1BA6EA0
	public void .ctor() { }

	// RVA: 0x1BA6FD0 Offset: 0x1BA70D1 VA: 0x1BA6FD0
	private static void .cctor() { }
}

