[RequiredByNativeCodeAttribute] // RVA: 0x1185C0 Offset: 0x1186C1 VA: 0x1185C0
[Serializable]
public class Tile : TileBase // TypeDefIndex: 3893
{
	// Fields
	[SerializeField] // RVA: 0x118900 Offset: 0x118A01 VA: 0x118900
	private Sprite m_Sprite; // 0x18
	[SerializeField] // RVA: 0x118910 Offset: 0x118A11 VA: 0x118910
	private Color m_Color; // 0x20
	[SerializeField] // RVA: 0x118920 Offset: 0x118A21 VA: 0x118920
	private Matrix4x4 m_Transform; // 0x30
	[SerializeField] // RVA: 0x118930 Offset: 0x118A31 VA: 0x118930
	private GameObject m_InstancedGameObject; // 0x70
	[SerializeField] // RVA: 0x118940 Offset: 0x118A41 VA: 0x118940
	private TileFlags m_Flags; // 0x78
	[SerializeField] // RVA: 0x118950 Offset: 0x118A51 VA: 0x118950
	private Tile.ColliderType m_ColliderType; // 0x7C

	// Properties
	public Sprite sprite { get; set; }
	public Color color { get; set; }
	public Matrix4x4 transform { get; set; }
	public GameObject gameObject { get; set; }
	public TileFlags flags { get; set; }
	public Tile.ColliderType colliderType { get; set; }

	// Methods

	// RVA: 0x1BE00C0 Offset: 0x1BE01C1 VA: 0x1BE00C0
	public Sprite get_sprite() { }

	// RVA: 0x1BE00D0 Offset: 0x1BE01D1 VA: 0x1BE00D0
	public void set_sprite(Sprite value) { }

	// RVA: 0x1BE00E0 Offset: 0x1BE01E1 VA: 0x1BE00E0
	public Color get_color() { }

	// RVA: 0x1BE00F0 Offset: 0x1BE01F1 VA: 0x1BE00F0
	public void set_color(Color value) { }

	// RVA: 0x1BE0110 Offset: 0x1BE0211 VA: 0x1BE0110
	public Matrix4x4 get_transform() { }

	// RVA: 0x1BE0140 Offset: 0x1BE0241 VA: 0x1BE0140
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x1BE0160 Offset: 0x1BE0261 VA: 0x1BE0160
	public GameObject get_gameObject() { }

	// RVA: 0x1BE0170 Offset: 0x1BE0271 VA: 0x1BE0170
	public void set_gameObject(GameObject value) { }

	// RVA: 0x1BE0180 Offset: 0x1BE0281 VA: 0x1BE0180
	public TileFlags get_flags() { }

	// RVA: 0x1BE0190 Offset: 0x1BE0291 VA: 0x1BE0190
	public void set_flags(TileFlags value) { }

	// RVA: 0x1BE01A0 Offset: 0x1BE02A1 VA: 0x1BE01A0
	public Tile.ColliderType get_colliderType() { }

	// RVA: 0x1BE01B0 Offset: 0x1BE02B1 VA: 0x1BE01B0
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x1BE01C0 Offset: 0x1BE02C1 VA: 0x1BE01C0 Slot: 5
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x1BE02B0 Offset: 0x1BE03B1 VA: 0x1BE02B0
	public void .ctor() { }
}

