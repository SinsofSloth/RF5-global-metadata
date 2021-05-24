[NativeTypeAttribute] // RVA: 0x118840 Offset: 0x118941 VA: 0x118840
[RequiredByNativeCodeAttribute] // RVA: 0x118840 Offset: 0x118941 VA: 0x118840
public struct TileData // TypeDefIndex: 3899
{
	// Fields
	private Sprite m_Sprite; // 0x0
	private Color m_Color; // 0x8
	private Matrix4x4 m_Transform; // 0x18
	private GameObject m_GameObject; // 0x58
	private TileFlags m_Flags; // 0x60
	private Tile.ColliderType m_ColliderType; // 0x64

	// Properties
	public Sprite sprite { set; }
	public Color color { set; }
	public Matrix4x4 transform { set; }
	public GameObject gameObject { set; }
	public TileFlags flags { set; }
	public Tile.ColliderType colliderType { set; }

	// Methods

	// RVA: 0x26EF0 Offset: 0x26FF1 VA: 0x26EF0
	public void set_sprite(Sprite value) { }

	// RVA: 0x26F00 Offset: 0x27001 VA: 0x26F00
	public void set_color(Color value) { }

	// RVA: 0x26F20 Offset: 0x27021 VA: 0x26F20
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x26F40 Offset: 0x27041 VA: 0x26F40
	public void set_gameObject(GameObject value) { }

	// RVA: 0x26F50 Offset: 0x27051 VA: 0x26F50
	public void set_flags(TileFlags value) { }

	// RVA: 0x26F60 Offset: 0x27061 VA: 0x26F60
	public void set_colliderType(Tile.ColliderType value) { }
}

