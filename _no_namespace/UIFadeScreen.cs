public class UIFadeScreen : MonoBehaviour // TypeDefIndex: 8439
{
	// Fields
	[SerializeField] // RVA: 0x16F880 Offset: 0x16F981 VA: 0x16F880
	private Image BlackOutPanel; // 0x18
	private Color PanelColor; // 0x20
	private Color StartFadeColor; // 0x30
	private Color TargetColor; // 0x40
	private float FadeTime; // 0x50
	private float nowFadeTime; // 0x54
	private Action<bool> endCallback; // 0x58

	// Methods

	// RVA: 0x1F15000 Offset: 0x1F15101 VA: 0x1F15000
	public void ScreenFade(float fadeTime, Color fadeColor, int fadeStat, Action<bool> _endCallback) { }

	// RVA: 0x1F151F0 Offset: 0x1F152F1 VA: 0x1F151F0
	public bool IsToBlack() { }

	// RVA: 0x1F15250 Offset: 0x1F15351 VA: 0x1F15250
	private void Awake() { }

	// RVA: 0x1F152C0 Offset: 0x1F153C1 VA: 0x1F152C0
	private void Update() { }

	// RVA: 0x1F15420 Offset: 0x1F15521 VA: 0x1F15420
	public void .ctor() { }
}

