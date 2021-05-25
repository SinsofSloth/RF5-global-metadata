public class TCP2_Demo_View : MonoBehaviour // TypeDefIndex: 8995
{
	// Fields
	[HeaderAttribute] // RVA: 0x175390 Offset: 0x175491 VA: 0x175390
	public float OrbitStrg; // 0x18
	public float OrbitClamp; // 0x1C
	[HeaderAttribute] // RVA: 0x1753D0 Offset: 0x1754D1 VA: 0x1753D0
	public float PanStrg; // 0x20
	public float PanClamp; // 0x24
	[HeaderAttribute] // RVA: 0x175410 Offset: 0x175511 VA: 0x175410
	public float ZoomStrg; // 0x28
	public float ZoomClamp; // 0x2C
	[HeaderAttribute] // RVA: 0x175450 Offset: 0x175551 VA: 0x175450
	public float Decceleration; // 0x30
	public Transform CharacterTransform; // 0x38
	private Vector3 mouseDelta; // 0x40
	private Vector3 orbitAcceleration; // 0x4C
	private Vector3 panAcceleration; // 0x58
	private Vector3 moveAcceleration; // 0x64
	private float zoomAcceleration; // 0x70
	private const float XMax = 60;
	private const float XMin = 300;
	private Vector3 mResetCamPos; // 0x74
	private Vector3 mResetCamRot; // 0x80
	private bool mMouseDown; // 0x8C

	// Methods

	// RVA: 0x1C70F80 Offset: 0x1C71081 VA: 0x1C70F80
	private void Awake() { }

	// RVA: 0x1C70FF0 Offset: 0x1C710F1 VA: 0x1C70FF0
	private void OnEnable() { }

	// RVA: 0x1C71020 Offset: 0x1C71121 VA: 0x1C71020
	private void Update() { }

	// RVA: 0x1C71810 Offset: 0x1C71911 VA: 0x1C71810
	public void ResetView() { }

	// RVA: 0x1C71880 Offset: 0x1C71981 VA: 0x1C71880
	public void .ctor() { }
}

