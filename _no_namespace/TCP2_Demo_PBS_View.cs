public class TCP2_Demo_PBS_View : MonoBehaviour // TypeDefIndex: 8994
{
	// Fields
	public Transform Pivot; // 0x18
	[HeaderAttribute] // RVA: 0x175290 Offset: 0x175391 VA: 0x175290
	public float OrbitStrg; // 0x20
	public float OrbitClamp; // 0x24
	[HeaderAttribute] // RVA: 0x1752D0 Offset: 0x1753D1 VA: 0x1752D0
	public float PanStrg; // 0x28
	public float PanClamp; // 0x2C
	public float yMin; // 0x30
	public float yMax; // 0x34
	[HeaderAttribute] // RVA: 0x175310 Offset: 0x175411 VA: 0x175310
	public float ZoomStrg; // 0x38
	public float ZoomClamp; // 0x3C
	public float ZoomDistMin; // 0x40
	public float ZoomDistMax; // 0x44
	[HeaderAttribute] // RVA: 0x175350 Offset: 0x175451 VA: 0x175350
	public float Decceleration; // 0x48
	public Rect ignoreMouseRect; // 0x4C
	private Vector3 mouseDelta; // 0x5C
	private Vector3 orbitAcceleration; // 0x68
	private Vector3 panAcceleration; // 0x74
	private Vector3 moveAcceleration; // 0x80
	private float zoomAcceleration; // 0x8C
	private const float XMax = 60;
	private const float XMin = 300;
	private Vector3 mResetCamPos; // 0x90
	private Vector3 mResetPivotPos; // 0x9C
	private Vector3 mResetCamRot; // 0xA8
	private Vector3 mResetPivotRot; // 0xB4
	private bool leftMouseHeld; // 0xC0
	private bool rightMouseHeld; // 0xC1
	private bool middleMouseHeld; // 0xC2

	// Methods

	// RVA: 0x1C70570 Offset: 0x1C70671 VA: 0x1C70570
	private void Awake() { }

	// RVA: 0x1C70600 Offset: 0x1C70701 VA: 0x1C70600
	private void OnEnable() { }

	// RVA: 0x1C70630 Offset: 0x1C70731 VA: 0x1C70630
	private void Update() { }

	// RVA: 0x1C70E30 Offset: 0x1C70F31 VA: 0x1C70E30
	public void ResetView() { }

	// RVA: 0x1C70F40 Offset: 0x1C71041 VA: 0x1C70F40
	public void .ctor() { }
}

