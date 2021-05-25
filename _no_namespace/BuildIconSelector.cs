public class BuildIconSelector : MonoBehaviour // TypeDefIndex: 8628
{
	// Fields
	[SerializeField] // RVA: 0x171380 Offset: 0x171481 VA: 0x171380
	private float MoveSpeed; // 0x18
	[SerializeField] // RVA: 0x171390 Offset: 0x171491 VA: 0x171390
	private MapControl mapCntl; // 0x20
	private RectTransform rect; // 0x28
	private Vector2 oldTouchPos; // 0x30
	private float oldTouchTime; // 0x38
	private TouchState touchState; // 0x3C
	public bool IsActiveInput; // 0x40
	public bool IsActiveInputKey; // 0x41
	public bool IsActiveInputTouch; // 0x42
	private float imageSize; // 0x44
	private Rect worldRect; // 0x48
	private Vector2 moveSize; // 0x58

	// Methods

	// RVA: 0x205E7D0 Offset: 0x205E8D1 VA: 0x205E7D0
	private void Start() { }

	// RVA: 0x205E8B0 Offset: 0x205E9B1 VA: 0x205E8B0
	private void Update() { }

	// RVA: 0x205E8C0 Offset: 0x205E9C1 VA: 0x205E8C0
	public void updateCursor() { }

	// RVA: 0x205F280 Offset: 0x205F381 VA: 0x205F280
	public TouchState getTouchState() { }

	// RVA: 0x205F290 Offset: 0x205F391 VA: 0x205F290
	public void setCursorPos(Vector2 pos) { }

	// RVA: 0x205F340 Offset: 0x205F441 VA: 0x205F340
	public void .ctor() { }
}

