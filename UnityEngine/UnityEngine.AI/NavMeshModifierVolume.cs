[ExecuteInEditMode] // RVA: 0x140DB0 Offset: 0x140EB1 VA: 0x140DB0
[AddComponentMenu] // RVA: 0x140DB0 Offset: 0x140EB1 VA: 0x140DB0
[HelpURLAttribute] // RVA: 0x140DB0 Offset: 0x140EB1 VA: 0x140DB0
public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 5917
{
	// Fields
	[SerializeField] // RVA: 0x140F90 Offset: 0x141091 VA: 0x140F90
	private Vector3 m_Size; // 0x18
	[SerializeField] // RVA: 0x140FA0 Offset: 0x1410A1 VA: 0x140FA0
	private Vector3 m_Center; // 0x24
	[SerializeField] // RVA: 0x140FB0 Offset: 0x1410B1 VA: 0x140FB0
	private int m_Area; // 0x30
	[SerializeField] // RVA: 0x140FC0 Offset: 0x1410C1 VA: 0x140FC0
	private List<int> m_AffectedAgents; // 0x38
	private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; // 0x0

	// Properties
	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public int area { get; set; }
	public static List<NavMeshModifierVolume> activeModifiers { get; }

	// Methods

	// RVA: 0x1BA7490 Offset: 0x1BA7591 VA: 0x1BA7490
	public Vector3 get_size() { }

	// RVA: 0x1BA74A0 Offset: 0x1BA75A1 VA: 0x1BA74A0
	public void set_size(Vector3 value) { }

	// RVA: 0x1BA74B0 Offset: 0x1BA75B1 VA: 0x1BA74B0
	public Vector3 get_center() { }

	// RVA: 0x1BA74C0 Offset: 0x1BA75C1 VA: 0x1BA74C0
	public void set_center(Vector3 value) { }

	// RVA: 0x1BA74D0 Offset: 0x1BA75D1 VA: 0x1BA74D0
	public int get_area() { }

	// RVA: 0x1BA74E0 Offset: 0x1BA75E1 VA: 0x1BA74E0
	public void set_area(int value) { }

	// RVA: 0x1BA74F0 Offset: 0x1BA75F1 VA: 0x1BA74F0
	public static List<NavMeshModifierVolume> get_activeModifiers() { }

	// RVA: 0x1BA7560 Offset: 0x1BA7661 VA: 0x1BA7560
	private void OnEnable() { }

	// RVA: 0x1BA7630 Offset: 0x1BA7731 VA: 0x1BA7630
	private void OnDisable() { }

	// RVA: 0x1BA76C0 Offset: 0x1BA77C1 VA: 0x1BA76C0
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x1BA7780 Offset: 0x1BA7881 VA: 0x1BA7780
	public void .ctor() { }

	// RVA: 0x1BA78B0 Offset: 0x1BA79B1 VA: 0x1BA78B0
	private static void .cctor() { }
}

