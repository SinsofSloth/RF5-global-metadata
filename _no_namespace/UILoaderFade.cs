public class UILoaderFade : MonoBehaviour // TypeDefIndex: 8762
{
	// Fields
	[SerializeField] // RVA: 0x1733F0 Offset: 0x1734F1 VA: 0x1733F0
	private UILoaderFade.State state; // 0x18
	[SerializeField] // RVA: 0x173400 Offset: 0x173501 VA: 0x173400
	private UILoader UILoader; // 0x20
	[SerializeField] // RVA: 0x173410 Offset: 0x173511 VA: 0x173410
	private float[] fadeTime; // 0x28
	private float nowFadeTime; // 0x30
	private float nextFadeTime; // 0x34
	private int fadePhase; // 0x38
	private bool initPhase; // 0x3C
	private Image Image; // 0x40
	private Color Color; // 0x48

	// Methods

	// RVA: 0x1ED9580 Offset: 0x1ED9681 VA: 0x1ED9580
	private void Awake() { }

	// RVA: 0x1ED7F30 Offset: 0x1ED8031 VA: 0x1ED7F30
	public void Init() { }

	// RVA: 0x1ED9610 Offset: 0x1ED9711 VA: 0x1ED9610
	private void CalcFadeTime() { }

	// RVA: 0x1ED96C0 Offset: 0x1ED97C1 VA: 0x1ED96C0
	private void Update() { }

	// RVA: 0x1ED99D0 Offset: 0x1ED9AD1 VA: 0x1ED99D0
	public void .ctor() { }
}

