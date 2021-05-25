public class GandageHandController : MonoBehaviour // TypeDefIndex: 7854
{
	// Fields
	[SerializeField] // RVA: 0x169C00 Offset: 0x169D01 VA: 0x169C00
	private GandageHandController.ArmType _ArmType; // 0x18
	public GandageHandController.MaterialFadeController _MaterialFadeController; // 0x20
	public TweenerCore<Vector3, Path, PathOptions> Tweener; // 0x28
	private PathOptions Option; // 0x30
	public bool IsSetup; // 0xA0

	// Methods

	// RVA: 0x1E38630 Offset: 0x1E38731 VA: 0x1E38630
	private void Awake() { }

	// RVA: 0x1E387B0 Offset: 0x1E388B1 VA: 0x1E387B0
	private void Update() { }

	// RVA: 0x1E38940 Offset: 0x1E38A41 VA: 0x1E38940
	public void StartMoveCubicBezier(Vector3 point, Vector3 initPosition, Vector3[] path01, Vector3[] path02, float time01, float time02) { }

	// RVA: 0x1E37670 Offset: 0x1E37771 VA: 0x1E37670
	public void SetDisplayHand(bool isDisplay, float fadeTime, Vector3 localposition, Vector3 localRotation) { }

	// RVA: 0x1E38470 Offset: 0x1E38571 VA: 0x1E38470
	public void SetDisplayHand(bool isDisplay, float fadeTime) { }

	// RVA: 0x1E377B0 Offset: 0x1E378B1 VA: 0x1E377B0
	public void MoveCubicBezier(Vector3[] path, float time, float lookAHead, Vector3 forward, Vector3 up, Action callBack) { }

	// RVA: 0x1E38D00 Offset: 0x1E38E01 VA: 0x1E38D00
	public void .ctor() { }
}

