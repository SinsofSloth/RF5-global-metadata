public class MapShaderController : MonoBehaviour // TypeDefIndex: 8632
{
	// Fields
	[SerializeField] // RVA: 0x1714E0 Offset: 0x1715E1 VA: 0x1714E0
	private RectTransform MapRect; // 0x18
	[SerializeField] // RVA: 0x1714F0 Offset: 0x1715F1 VA: 0x1714F0
	private Image image; // 0x20
	[SerializeField] // RVA: 0x171500 Offset: 0x171601 VA: 0x171500
	private float MapSize; // 0x28
	[SerializeField] // RVA: 0x171510 Offset: 0x171611 VA: 0x171510
	private float FieldSize; // 0x2C
	[SerializeField] // RVA: 0x171520 Offset: 0x171621 VA: 0x171520
	private Vector3 OriginPos; // 0x30
	[SerializeField] // RVA: 0x171530 Offset: 0x171631 VA: 0x171530
	private bool inRoom; // 0x3C
	[SerializeField] // RVA: 0x171540 Offset: 0x171641 VA: 0x171540
	private float[] MapScaleSize; // 0x40
	private Material material; // 0x48
	private Vector3 PlayerPos; // 0x50
	private float oldScale; // 0x5C
	private Texture2D texMask; // 0x60
	private byte[] buffMask; // 0x68
	private Vector2 MapSizeRect; // 0x70
	private float MapScale; // 0x78

	// Methods

	// RVA: 0x1E1DE00 Offset: 0x1E1DF01 VA: 0x1E1DE00
	private void Start() { }

	// RVA: 0x1E1E060 Offset: 0x1E1E161 VA: 0x1E1E060
	private void Update() { }

	// RVA: 0x1E1E070 Offset: 0x1E1E171 VA: 0x1E1E070
	private void OnDestroy() { }

	// RVA: 0x1E1E0F0 Offset: 0x1E1E1F1 VA: 0x1E1E0F0
	private void setScale(float scale) { }

	// RVA: 0x1E1E170 Offset: 0x1E1E271 VA: 0x1E1E170
	private void createTextureMask(byte[] masklist) { }

	// RVA: 0x1E1DFC0 Offset: 0x1E1E0C1 VA: 0x1E1DFC0
	public void updateMap(Vector3 pos) { }

	// RVA: 0x1E19920 Offset: 0x1E19A21 VA: 0x1E19920
	public Vector3 getIconMapPos(Vector3 pos) { }

	// RVA: 0x1E1E250 Offset: 0x1E1E351 VA: 0x1E1E250
	public float getMapSize() { }

	// RVA: 0x1E1E260 Offset: 0x1E1E361 VA: 0x1E1E260
	public float getFieldSize() { }

	// RVA: 0x1E1E270 Offset: 0x1E1E371 VA: 0x1E1E270
	public bool IsRoom() { }

	// RVA: 0x1E1B840 Offset: 0x1E1B941 VA: 0x1E1B840
	public float getMapScale(int no) { }

	// RVA: 0x1E1E280 Offset: 0x1E1E381 VA: 0x1E1E280
	public void .ctor() { }
}

