public class BulletManager : SingletonMonoBehaviour<BulletManager> // TypeDefIndex: 6696
{
	// Fields
	private List<BulletBase> m_bullets; // 0x18
	private Dictionary<GameObject, Prefab> m_loadIdList; // 0x20
	[TupleElementNamesAttribute] // RVA: 0x15EE00 Offset: 0x15EF01 VA: 0x15EE00
	private List<ValueTuple<int, GameObject, Vector3, Quaternion, BulletDataTable, Action<BulletBase, BulletDataTable>>> m_InitList; // 0x28

	// Methods

	// RVA: 0x20612D0 Offset: 0x20613D1 VA: 0x20612D0
	public bool Regist(BulletBase bullet) { }

	// RVA: 0x20614D0 Offset: 0x20615D1 VA: 0x20614D0
	public bool Remove(BulletBase bullet) { }

	// RVA: 0x206AB50 Offset: 0x206AC51 VA: 0x206AB50
	public void Update() { }

	// RVA: 0x206B030 Offset: 0x206B131 VA: 0x206B030
	public void FixedUpdate() { }

	// RVA: 0x206B140 Offset: 0x206B241 VA: 0x206B140
	public bool CreateBullet(BulletID bulletID, Character chara, Vector3 offset, Quaternion rotationOffset, Transform parent, Action<BulletBase, BulletDataTable> complate) { }

	// RVA: 0x206B300 Offset: 0x206B401 VA: 0x206B300
	public void ForceDestroyAll() { }

	// RVA: 0x206AD40 Offset: 0x206AE41 VA: 0x206AD40
	private void InitBullet(int assetId, GameObject asset, Vector3 position, Quaternion rotation, BulletDataTable table, Action<BulletBase, BulletDataTable> complate) { }

	// RVA: 0x206B410 Offset: 0x206B511 VA: 0x206B410
	public void .ctor() { }
}

