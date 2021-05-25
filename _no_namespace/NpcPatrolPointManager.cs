[Serializable]
public class NpcPatrolPointManager : SingletonMonoBehaviour<NpcPatrolPointManager> // TypeDefIndex: 8244
{
	// Fields
	[SerializeField] // RVA: 0x16E4E0 Offset: 0x16E5E1 VA: 0x16E4E0
	private PositinoList m_PotisionArray; // 0x18
	[SerializeField] // RVA: 0x16E4F0 Offset: 0x16E5F1 VA: 0x16E4F0
	private List<GameObject> m_MobRoutePotisionList; // 0x20
	private Dictionary<string, GameObject> m_PointTable; // 0x28

	// Methods

	// RVA: 0x1D8AC50 Offset: 0x1D8AD51 VA: 0x1D8AC50 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1D8AD60 Offset: 0x1D8AE61 VA: 0x1D8AD60
	public void SetArea() { }

	// RVA: 0x1D859F0 Offset: 0x1D85AF1 VA: 0x1D859F0
	public GameObject GetPoint(string name) { }

	// RVA: 0x1D8ADE0 Offset: 0x1D8AEE1 VA: 0x1D8ADE0
	public GameObject GetMobRoutePoint(int idx) { }

	// RVA: 0x1D8AE60 Offset: 0x1D8AF61 VA: 0x1D8AE60
	public int GetMobRoutePointNum() { }

	// RVA: 0x1D8AEB0 Offset: 0x1D8AFB1 VA: 0x1D8AEB0
	public void .ctor() { }
}

