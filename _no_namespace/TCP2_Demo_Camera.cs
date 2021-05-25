public class TCP2_Demo_Camera : MonoBehaviour // TypeDefIndex: 8983
{
	// Fields
	public Transform Pivot; // 0x18
	[HeaderAttribute] // RVA: 0x1750F0 Offset: 0x1751F1 VA: 0x1750F0
	public float OrbitStrg; // 0x20
	public float OrbitClamp; // 0x24
	[HeaderAttribute] // RVA: 0x175130 Offset: 0x175231 VA: 0x175130
	public float PanStrgMin; // 0x28
	public float PanStrgMax; // 0x2C
	[HeaderAttribute] // RVA: 0x175170 Offset: 0x175271 VA: 0x175170
	public float ZoomStrg; // 0x30
	public float ZoomClamp; // 0x34
	public float ZoomDistMin; // 0x38
	public float ZoomDistMax; // 0x3C
	[HeaderAttribute] // RVA: 0x1751B0 Offset: 0x1752B1 VA: 0x1751B0
	public float Decceleration; // 0x40
	public RectTransform ignoreMouseRect; // 0x48
	private Vector3 mouseDelta; // 0x50
	private Vector3 orbitAcceleration; // 0x5C
	private Vector3 panAcceleration; // 0x68
	private Vector3 moveAcceleration; // 0x74
	private float zoomAcceleration; // 0x80
	private float zoomDistance; // 0x84
	private const float XMax = 60;
	private const float XMin = 300;
	private Vector3 mResetCamPos; // 0x88
	private Vector3 mResetPivotPos; // 0x94
	private Vector3 mResetCamRot; // 0xA0
	private Vector3 mResetPivotRot; // 0xAC
	private bool leftMouseHeld; // 0xB8
	private bool rightMouseHeld; // 0xB9
	private bool middleMouseHeld; // 0xBA

	// Methods

	// RVA: 0x1C6D680 Offset: 0x1C6D781 VA: 0x1C6D680
	private void Awake() { }

	// RVA: 0x1C6D710 Offset: 0x1C6D811 VA: 0x1C6D710
	private void OnEnable() { }

	// RVA: 0x1C6D740 Offset: 0x1C6D841 VA: 0x1C6D740
	private void Update() { }

	// RVA: 0x1C6DFB0 Offset: 0x1C6E0B1 VA: 0x1C6DFB0
	public void ResetView() { }

	// RVA: 0x1C6E0C0 Offset: 0x1C6E1C1 VA: 0x1C6E0C0
	public void .ctor() { }
}

