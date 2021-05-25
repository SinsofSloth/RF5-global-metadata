public class MiniMapShaderController : MonoBehaviour // TypeDefIndex: 8633
{
	// Fields
	[SerializeField] // RVA: 0x171550 Offset: 0x171651 VA: 0x171550
	private RectTransform MapRect; // 0x18
	[SerializeField] // RVA: 0x171560 Offset: 0x171661 VA: 0x171560
	private Image image; // 0x20
	[SerializeField] // RVA: 0x171570 Offset: 0x171671 VA: 0x171570
	private float FieldSize; // 0x28
	[SerializeField] // RVA: 0x171580 Offset: 0x171681 VA: 0x171580
	private float MapSize; // 0x2C
	[SerializeField] // RVA: 0x171590 Offset: 0x171691 VA: 0x171590
	private Vector3 OriginPos; // 0x30
	[SerializeField] // RVA: 0x1715A0 Offset: 0x1716A1 VA: 0x1715A0
	private Vector3 MapOffset; // 0x3C
	[SerializeField] // RVA: 0x1715B0 Offset: 0x1716B1 VA: 0x1715B0
	private bool inRoom; // 0x48
	[SerializeField] // RVA: 0x1715C0 Offset: 0x1716C1 VA: 0x1715C0
	private Vector3 MapOffset2F; // 0x4C
	[SerializeField] // RVA: 0x1715D0 Offset: 0x1716D1 VA: 0x1715D0
	private float Map2FY; // 0x58
	[SerializeField] // RVA: 0x1715E0 Offset: 0x1716E1 VA: 0x1715E0
	private float[] MapScaleSize; // 0x60
	private Material material; // 0x68
	private Vector3 PlayerPos; // 0x70
	private float oldScale; // 0x7C
	private Texture2D texMask; // 0x80
	private byte[] buffMask; // 0x88
	private Vector2[] MapRectTbl; // 0x90

	// Methods

	// RVA: 0x235A640 Offset: 0x235A741 VA: 0x235A640
	private void Awake() { }

	// RVA: 0x235AA40 Offset: 0x235AB41 VA: 0x235AA40
	private void Update() { }

	// RVA: 0x235AA50 Offset: 0x235AB51 VA: 0x235AA50
	private void OnDestroy() { }

	// RVA: 0x235AAD0 Offset: 0x235ABD1 VA: 0x235AAD0
	private void setMapPos(Vector3 plyPos) { }

	// RVA: 0x235AD90 Offset: 0x235AE91 VA: 0x235AD90
	private void setScale(float scale) { }

	// RVA: 0x235A980 Offset: 0x235AA81 VA: 0x235A980
	private void createTextureMask(byte[] masklist) { }

	// RVA: 0x235AE50 Offset: 0x235AF51 VA: 0x235AE50
	private float getScale(int type) { }

	// RVA: 0x235A8B0 Offset: 0x235A9B1 VA: 0x235A8B0
	public void updateMap(int scaleType, Vector3 pos) { }

	// RVA: 0x235AE90 Offset: 0x235AF91 VA: 0x235AE90
	public void updateMapPos(Vector3 pos) { }

	// RVA: 0x235AF70 Offset: 0x235B071 VA: 0x235AF70
	public Vector3 getIconMapPos(Vector3 pos, Vector3 plyPos) { }

	// RVA: 0x235B1E0 Offset: 0x235B2E1 VA: 0x235B1E0
	public bool IsRoom() { }

	// RVA: 0x235B1F0 Offset: 0x235B2F1 VA: 0x235B1F0
	public Vector3 getPlayerPos() { }

	// RVA: 0x235B200 Offset: 0x235B301 VA: 0x235B200
	public void setMaskImage(Sprite spr) { }

	// RVA: 0x235B280 Offset: 0x235B381 VA: 0x235B280
	public void .ctor() { }
}

