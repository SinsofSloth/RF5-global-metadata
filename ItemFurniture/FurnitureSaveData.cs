[Serializable]
public class FurnitureSaveData // TypeDefIndex: 10272
{
	// Fields
	[SerializeField] // RVA: 0x180C80 Offset: 0x180D81 VA: 0x180C80
	public Vector3 Pos; // 0x10
	[SerializeField] // RVA: 0x180C90 Offset: 0x180D91 VA: 0x180C90
	public Quaternion Rot; // 0x1C
	[SerializeField] // RVA: 0x180CA0 Offset: 0x180DA1 VA: 0x180CA0
	public FieldSceneId SceneId; // 0x2C
	[SerializeField] // RVA: 0x180CB0 Offset: 0x180DB1 VA: 0x180CB0
	public FurnitureID Id; // 0x30
	[SerializeField] // RVA: 0x180CC0 Offset: 0x180DC1 VA: 0x180CC0
	public string UniqueId; // 0x38
	[SerializeField] // RVA: 0x180CD0 Offset: 0x180DD1 VA: 0x180CD0
	public FurnitureCreatePoint Point; // 0x40
	[SerializeField] // RVA: 0x180CE0 Offset: 0x180DE1 VA: 0x180CE0
	public int Hp; // 0x44
	[SerializeField] // RVA: 0x180CF0 Offset: 0x180DF1 VA: 0x180CF0
	public bool Have; // 0x48

	// Methods

	// RVA: 0x1F39750 Offset: 0x1F39851 VA: 0x1F39750
	public void .ctor(int type = 0) { }

	// RVA: 0x1F32790 Offset: 0x1F32891 VA: 0x1F32790
	public void .ctor(Vector3 pos, Quaternion rot, FieldSceneId scene_id, FurnitureID fid, string unique_id, FurnitureCreatePoint point, int hp, bool have = False) { }
}

