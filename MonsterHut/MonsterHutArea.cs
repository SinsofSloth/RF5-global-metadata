public class MonsterHutArea : MonoBehaviour, MonsterHutAreaInterface // TypeDefIndex: 9928
{
	// Fields
	[SerializeField] // RVA: 0x17FAA0 Offset: 0x17FBA1 VA: 0x17FAA0
	public int AreaIndex; // 0x18
	[SerializeField] // RVA: 0x17FAB0 Offset: 0x17FBB1 VA: 0x17FAB0
	public List<Transform> Transforms; // 0x20
	[SerializeField] // RVA: 0x17FAC0 Offset: 0x17FBC1 VA: 0x17FAC0
	public Collider AreaCollider; // 0x28
	[SerializeField] // RVA: 0x17FAD0 Offset: 0x17FBD1 VA: 0x17FAD0
	public UnityEventInteger OnPlayerEnterArea; // 0x30
	private bool[] IsExistPointFlags; // 0x38
	private int[] MonsterLoveLvs; // 0x40
	private int MostLoveLvPointIndex; // 0x48

	// Methods

	// RVA: 0x2173B80 Offset: 0x2173C81 VA: 0x2173B80
	public void Initialize() { }

	// RVA: 0x2173C00 Offset: 0x2173D01 VA: 0x2173C00 Slot: 4
	public int GetFreePointIndex() { }

	// RVA: 0x2173C70 Offset: 0x2173D71 VA: 0x2173C70 Slot: 5
	public void LockPointIndex(int index) { }

	// RVA: 0x2173CC0 Offset: 0x2173DC1 VA: 0x2173CC0 Slot: 6
	public void RelesePointIndex(int index) { }

	// RVA: 0x2173D10 Offset: 0x2173E11 VA: 0x2173D10 Slot: 9
	public Transform GetPointTransfrom(int index) { }

	// RVA: 0x2173DB0 Offset: 0x2173EB1 VA: 0x2173DB0 Slot: 7
	public void UpdateLoveLv(int index, int loveLv) { }

	// RVA: 0x2173E00 Offset: 0x2173F01 VA: 0x2173E00 Slot: 8
	public bool IsMostLoveLvMonster(int index) { }

	// RVA: 0x2173E10 Offset: 0x2173F11 VA: 0x2173E10
	public void SelectMostLoveLevelIndex() { }

	// RVA: 0x2173FB0 Offset: 0x21740B1 VA: 0x2173FB0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x21740F0 Offset: 0x21741F1 VA: 0x21740F0
	public void .ctor() { }
}

public class MonsterHutArea : MonoBehaviour, MonsterHutAreaInterface // TypeDefIndex: 9928
{
	// Fields
	[SerializeField] // RVA: 0x17FAA0 Offset: 0x17FBA1 VA: 0x17FAA0
	public int AreaIndex; // 0x18
	[SerializeField] // RVA: 0x17FAB0 Offset: 0x17FBB1 VA: 0x17FAB0
	public List<Transform> Transforms; // 0x20
	[SerializeField] // RVA: 0x17FAC0 Offset: 0x17FBC1 VA: 0x17FAC0
	public Collider AreaCollider; // 0x28
	[SerializeField] // RVA: 0x17FAD0 Offset: 0x17FBD1 VA: 0x17FAD0
	public UnityEventInteger OnPlayerEnterArea; // 0x30
	private bool[] IsExistPointFlags; // 0x38
	private int[] MonsterLoveLvs; // 0x40
	private int MostLoveLvPointIndex; // 0x48

	// Methods

	// RVA: 0x2173B80 Offset: 0x2173C81 VA: 0x2173B80
	public void Initialize() { }

	// RVA: 0x2173C00 Offset: 0x2173D01 VA: 0x2173C00 Slot: 4
	public int GetFreePointIndex() { }

	// RVA: 0x2173C70 Offset: 0x2173D71 VA: 0x2173C70 Slot: 5
	public void LockPointIndex(int index) { }

	// RVA: 0x2173CC0 Offset: 0x2173DC1 VA: 0x2173CC0 Slot: 6
	public void RelesePointIndex(int index) { }

	// RVA: 0x2173D10 Offset: 0x2173E11 VA: 0x2173D10 Slot: 9
	public Transform GetPointTransfrom(int index) { }

	// RVA: 0x2173DB0 Offset: 0x2173EB1 VA: 0x2173DB0 Slot: 7
	public void UpdateLoveLv(int index, int loveLv) { }

	// RVA: 0x2173E00 Offset: 0x2173F01 VA: 0x2173E00 Slot: 8
	public bool IsMostLoveLvMonster(int index) { }

	// RVA: 0x2173E10 Offset: 0x2173F11 VA: 0x2173E10
	public void SelectMostLoveLevelIndex() { }

	// RVA: 0x2173FB0 Offset: 0x21740B1 VA: 0x2173FB0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x21740F0 Offset: 0x21741F1 VA: 0x21740F0
	public void .ctor() { }
}

public class MonsterHutArea : MonoBehaviour, MonsterHutAreaInterface // TypeDefIndex: 9928
{
	// Fields
	[SerializeField] // RVA: 0x17FAA0 Offset: 0x17FBA1 VA: 0x17FAA0
	public int AreaIndex; // 0x18
	[SerializeField] // RVA: 0x17FAB0 Offset: 0x17FBB1 VA: 0x17FAB0
	public List<Transform> Transforms; // 0x20
	[SerializeField] // RVA: 0x17FAC0 Offset: 0x17FBC1 VA: 0x17FAC0
	public Collider AreaCollider; // 0x28
	[SerializeField] // RVA: 0x17FAD0 Offset: 0x17FBD1 VA: 0x17FAD0
	public UnityEventInteger OnPlayerEnterArea; // 0x30
	private bool[] IsExistPointFlags; // 0x38
	private int[] MonsterLoveLvs; // 0x40
	private int MostLoveLvPointIndex; // 0x48

	// Methods

	// RVA: 0x2173B80 Offset: 0x2173C81 VA: 0x2173B80
	public void Initialize() { }

	// RVA: 0x2173C00 Offset: 0x2173D01 VA: 0x2173C00 Slot: 4
	public int GetFreePointIndex() { }

	// RVA: 0x2173C70 Offset: 0x2173D71 VA: 0x2173C70 Slot: 5
	public void LockPointIndex(int index) { }

	// RVA: 0x2173CC0 Offset: 0x2173DC1 VA: 0x2173CC0 Slot: 6
	public void RelesePointIndex(int index) { }

	// RVA: 0x2173D10 Offset: 0x2173E11 VA: 0x2173D10 Slot: 9
	public Transform GetPointTransfrom(int index) { }

	// RVA: 0x2173DB0 Offset: 0x2173EB1 VA: 0x2173DB0 Slot: 7
	public void UpdateLoveLv(int index, int loveLv) { }

	// RVA: 0x2173E00 Offset: 0x2173F01 VA: 0x2173E00 Slot: 8
	public bool IsMostLoveLvMonster(int index) { }

	// RVA: 0x2173E10 Offset: 0x2173F11 VA: 0x2173E10
	public void SelectMostLoveLevelIndex() { }

	// RVA: 0x2173FB0 Offset: 0x21740B1 VA: 0x2173FB0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x21740F0 Offset: 0x21741F1 VA: 0x21740F0
	public void .ctor() { }
}

public class MonsterHutArea : MonoBehaviour, MonsterHutAreaInterface // TypeDefIndex: 9928
{
	// Fields
	[SerializeField] // RVA: 0x17FAA0 Offset: 0x17FBA1 VA: 0x17FAA0
	public int AreaIndex; // 0x18
	[SerializeField] // RVA: 0x17FAB0 Offset: 0x17FBB1 VA: 0x17FAB0
	public List<Transform> Transforms; // 0x20
	[SerializeField] // RVA: 0x17FAC0 Offset: 0x17FBC1 VA: 0x17FAC0
	public Collider AreaCollider; // 0x28
	[SerializeField] // RVA: 0x17FAD0 Offset: 0x17FBD1 VA: 0x17FAD0
	public UnityEventInteger OnPlayerEnterArea; // 0x30
	private bool[] IsExistPointFlags; // 0x38
	private int[] MonsterLoveLvs; // 0x40
	private int MostLoveLvPointIndex; // 0x48

	// Methods

	// RVA: 0x2173B80 Offset: 0x2173C81 VA: 0x2173B80
	public void Initialize() { }

	// RVA: 0x2173C00 Offset: 0x2173D01 VA: 0x2173C00 Slot: 4
	public int GetFreePointIndex() { }

	// RVA: 0x2173C70 Offset: 0x2173D71 VA: 0x2173C70 Slot: 5
	public void LockPointIndex(int index) { }

	// RVA: 0x2173CC0 Offset: 0x2173DC1 VA: 0x2173CC0 Slot: 6
	public void RelesePointIndex(int index) { }

	// RVA: 0x2173D10 Offset: 0x2173E11 VA: 0x2173D10 Slot: 9
	public Transform GetPointTransfrom(int index) { }

	// RVA: 0x2173DB0 Offset: 0x2173EB1 VA: 0x2173DB0 Slot: 7
	public void UpdateLoveLv(int index, int loveLv) { }

	// RVA: 0x2173E00 Offset: 0x2173F01 VA: 0x2173E00 Slot: 8
	public bool IsMostLoveLvMonster(int index) { }

	// RVA: 0x2173E10 Offset: 0x2173F11 VA: 0x2173E10
	public void SelectMostLoveLevelIndex() { }

	// RVA: 0x2173FB0 Offset: 0x21740B1 VA: 0x2173FB0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x21740F0 Offset: 0x21741F1 VA: 0x21740F0
	public void .ctor() { }
}

public class MonsterHutArea : MonoBehaviour, MonsterHutAreaInterface // TypeDefIndex: 9928
{
	// Fields
	[SerializeField] // RVA: 0x17FAA0 Offset: 0x17FBA1 VA: 0x17FAA0
	public int AreaIndex; // 0x18
	[SerializeField] // RVA: 0x17FAB0 Offset: 0x17FBB1 VA: 0x17FAB0
	public List<Transform> Transforms; // 0x20
	[SerializeField] // RVA: 0x17FAC0 Offset: 0x17FBC1 VA: 0x17FAC0
	public Collider AreaCollider; // 0x28
	[SerializeField] // RVA: 0x17FAD0 Offset: 0x17FBD1 VA: 0x17FAD0
	public UnityEventInteger OnPlayerEnterArea; // 0x30
	private bool[] IsExistPointFlags; // 0x38
	private int[] MonsterLoveLvs; // 0x40
	private int MostLoveLvPointIndex; // 0x48

	// Methods

	// RVA: 0x2173B80 Offset: 0x2173C81 VA: 0x2173B80
	public void Initialize() { }

	// RVA: 0x2173C00 Offset: 0x2173D01 VA: 0x2173C00 Slot: 4
	public int GetFreePointIndex() { }

	// RVA: 0x2173C70 Offset: 0x2173D71 VA: 0x2173C70 Slot: 5
	public void LockPointIndex(int index) { }

	// RVA: 0x2173CC0 Offset: 0x2173DC1 VA: 0x2173CC0 Slot: 6
	public void RelesePointIndex(int index) { }

	// RVA: 0x2173D10 Offset: 0x2173E11 VA: 0x2173D10 Slot: 9
	public Transform GetPointTransfrom(int index) { }

	// RVA: 0x2173DB0 Offset: 0x2173EB1 VA: 0x2173DB0 Slot: 7
	public void UpdateLoveLv(int index, int loveLv) { }

	// RVA: 0x2173E00 Offset: 0x2173F01 VA: 0x2173E00 Slot: 8
	public bool IsMostLoveLvMonster(int index) { }

	// RVA: 0x2173E10 Offset: 0x2173F11 VA: 0x2173E10
	public void SelectMostLoveLevelIndex() { }

	// RVA: 0x2173FB0 Offset: 0x21740B1 VA: 0x2173FB0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x21740F0 Offset: 0x21741F1 VA: 0x21740F0
	public void .ctor() { }
}

