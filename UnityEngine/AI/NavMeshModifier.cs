[ExecuteInEditMode] // RVA: 0x140D30 Offset: 0x140E31 VA: 0x140D30
[AddComponentMenu] // RVA: 0x140D30 Offset: 0x140E31 VA: 0x140D30
[HelpURLAttribute] // RVA: 0x140D30 Offset: 0x140E31 VA: 0x140D30
public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 5916
{
	// Fields
	[SerializeField] // RVA: 0x140F50 Offset: 0x141051 VA: 0x140F50
	private bool m_OverrideArea; // 0x18
	[SerializeField] // RVA: 0x140F60 Offset: 0x141061 VA: 0x140F60
	private int m_Area; // 0x1C
	[SerializeField] // RVA: 0x140F70 Offset: 0x141071 VA: 0x140F70
	private bool m_IgnoreFromBuild; // 0x20
	[SerializeField] // RVA: 0x140F80 Offset: 0x141081 VA: 0x140F80
	private List<int> m_AffectedAgents; // 0x28
	private static readonly List<NavMeshModifier> s_NavMeshModifiers; // 0x0

	// Properties
	public bool overrideArea { get; set; }
	public int area { get; set; }
	public bool ignoreFromBuild { get; set; }
	public static List<NavMeshModifier> activeModifiers { get; }

	// Methods

	// RVA: 0x1BA7050 Offset: 0x1BA7151 VA: 0x1BA7050
	public bool get_overrideArea() { }

	// RVA: 0x1BA7060 Offset: 0x1BA7161 VA: 0x1BA7060
	public void set_overrideArea(bool value) { }

	// RVA: 0x1BA7070 Offset: 0x1BA7171 VA: 0x1BA7070
	public int get_area() { }

	// RVA: 0x1BA7080 Offset: 0x1BA7181 VA: 0x1BA7080
	public void set_area(int value) { }

	// RVA: 0x1BA7090 Offset: 0x1BA7191 VA: 0x1BA7090
	public bool get_ignoreFromBuild() { }

	// RVA: 0x1BA70A0 Offset: 0x1BA71A1 VA: 0x1BA70A0
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x1BA70B0 Offset: 0x1BA71B1 VA: 0x1BA70B0
	public static List<NavMeshModifier> get_activeModifiers() { }

	// RVA: 0x1BA7120 Offset: 0x1BA7221 VA: 0x1BA7120
	private void OnEnable() { }

	// RVA: 0x1BA71F0 Offset: 0x1BA72F1 VA: 0x1BA71F0
	private void OnDisable() { }

	// RVA: 0x1BA7280 Offset: 0x1BA7381 VA: 0x1BA7280
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x1BA7340 Offset: 0x1BA7441 VA: 0x1BA7340
	public void .ctor() { }

	// RVA: 0x1BA7410 Offset: 0x1BA7511 VA: 0x1BA7410
	private static void .cctor() { }
}

