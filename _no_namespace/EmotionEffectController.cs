[ExecuteInEditMode] // RVA: 0x1460E0 Offset: 0x1461E1 VA: 0x1460E0
public class EmotionEffectController : MonoBehaviour // TypeDefIndex: 7112
{
	// Fields
	[SerializeField] // RVA: 0x162ED0 Offset: 0x162FD1 VA: 0x162ED0
	public GameObject m_Plane; // 0x18
	private const float DurationOpen = 0.15;
	private const float DurationClose = 0.15;
	private const float DurationIdle = 0.3;
	private EmotionEffectState m_state; // 0x20
	private float m_elapsed; // 0x24

	// Properties
	public EmotionEffectState CurrentState { get; }
	public bool IsPlaying { get; }

	// Methods

	// RVA: 0x201A770 Offset: 0x201A871 VA: 0x201A770
	public EmotionEffectState get_CurrentState() { }

	// RVA: 0x201A780 Offset: 0x201A881 VA: 0x201A780
	public bool get_IsPlaying() { }

	// RVA: 0x201A790 Offset: 0x201A891 VA: 0x201A790
	private void Reset() { }

	// RVA: 0x2019580 Offset: 0x2019681 VA: 0x2019580
	public void Open(bool plane = True) { }

	// RVA: 0x2019440 Offset: 0x2019541 VA: 0x2019440
	public void Close() { }

	// RVA: 0x201A830 Offset: 0x201A931 VA: 0x201A830
	public void SetState(EmotionEffectState state) { }

	// RVA: 0x201A840 Offset: 0x201A941 VA: 0x201A840
	public void Update() { }

	// RVA: 0x201A970 Offset: 0x201AA71 VA: 0x201A970
	private void OnOpen() { }

	// RVA: 0x201AAF0 Offset: 0x201ABF1 VA: 0x201AAF0
	private void OnIdle() { }

	// RVA: 0x201ABB0 Offset: 0x201ACB1 VA: 0x201ABB0
	private void OnClose() { }

	// RVA: 0x201A5D0 Offset: 0x201A6D1 VA: 0x201A5D0
	public void Delete() { }

	// RVA: 0x201ADA0 Offset: 0x201AEA1 VA: 0x201ADA0
	public void .ctor() { }
}

