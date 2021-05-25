public class FesMiniMapShaderController : MonoBehaviour // TypeDefIndex: 8631
{
	// Fields
	[SerializeField] // RVA: 0x171460 Offset: 0x171561 VA: 0x171460
	private RectTransform MapRect; // 0x18
	[SerializeField] // RVA: 0x171470 Offset: 0x171571 VA: 0x171470
	private Image image; // 0x20
	[SerializeField] // RVA: 0x171480 Offset: 0x171581 VA: 0x171480
	private float FieldSize; // 0x28
	[SerializeField] // RVA: 0x171490 Offset: 0x171591 VA: 0x171490
	private float MapSize; // 0x2C
	[SerializeField] // RVA: 0x1714A0 Offset: 0x1715A1 VA: 0x1714A0
	private Vector3 OriginPos; // 0x30
	[SerializeField] // RVA: 0x1714B0 Offset: 0x1715B1 VA: 0x1714B0
	private Vector3 MapOffset; // 0x3C
	[SerializeField] // RVA: 0x1714C0 Offset: 0x1715C1 VA: 0x1714C0
	private bool inRoom; // 0x48
	[SerializeField] // RVA: 0x1714D0 Offset: 0x1715D1 VA: 0x1714D0
	private Vector3 MapOffset2F; // 0x4C
	private Material material; // 0x58
	private FesMinimapControl fesMinimapCntl; // 0x60
	private Vector3 PlayerPos; // 0x68
	private float oldScale; // 0x74
	private Texture2D texMask; // 0x78
	private byte[] buffMask; // 0x80
	private Vector2[] MapRectTbl; // 0x88
	private float[] FesMapScale; // 0x90
	private float NormalMapScale; // 0x98

	// Methods

	// RVA: 0x2035E50 Offset: 0x2035F51 VA: 0x2035E50
	private void Start() { }

	// RVA: 0x2036170 Offset: 0x2036271 VA: 0x2036170
	private void Update() { }

	// RVA: 0x2036180 Offset: 0x2036281 VA: 0x2036180
	private void OnDestroy() { }

	// RVA: 0x2036050 Offset: 0x2036151 VA: 0x2036050
	public void updateMap(int scaleType, Vector3 pos) { }

	// RVA: 0x2036420 Offset: 0x2036521 VA: 0x2036420
	public void updateMapPos(Vector3 pos) { }

	// RVA: 0x2036280 Offset: 0x2036381 VA: 0x2036280
	private void setMapPos(Vector3 plyPos) { }

	// RVA: 0x2036200 Offset: 0x2036301 VA: 0x2036200
	private void setScale(float scale) { }

	// RVA: 0x2036500 Offset: 0x2036601 VA: 0x2036500
	public Vector3 getIconMapPos(Vector3 pos, Vector3 plyPos) { }

	// RVA: 0x2036620 Offset: 0x2036721 VA: 0x2036620
	public bool IsRoom() { }

	// RVA: 0x2036630 Offset: 0x2036731 VA: 0x2036630
	public Vector3 getPlayerPos() { }

	// RVA: 0x2036640 Offset: 0x2036741 VA: 0x2036640
	public void setMaskImage(Sprite spr) { }

	// RVA: 0x20366C0 Offset: 0x20367C1 VA: 0x20366C0
	public void setNormalScale() { }

	// RVA: 0x2036740 Offset: 0x2036841 VA: 0x2036740
	public void .ctor() { }
}

