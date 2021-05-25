public class UISubtitleVoiceComment : MonoBehaviour // TypeDefIndex: 8864
{
	// Fields
	[SerializeField] // RVA: 0x174550 Offset: 0x174651 VA: 0x174550
	private Image BorderImage; // 0x18
	[SerializeField] // RVA: 0x174560 Offset: 0x174661 VA: 0x174560
	private Text TextObject; // 0x20
	private SubtitleDataTable.DataList playList; // 0x28
	private UISystemTextData textData; // 0x30
	private AudioSource audioSource; // 0x38
	private float nTime; // 0x40
	private int nowPlayNo; // 0x44

	// Methods

	// RVA: 0x1FF7120 Offset: 0x1FF7221 VA: 0x1FF7120
	private void Awake() { }

	// RVA: 0x1FF7130 Offset: 0x1FF7231 VA: 0x1FF7130
	private void OnDestroy() { }

	// RVA: 0x1FF7200 Offset: 0x1FF7301 VA: 0x1FF7200
	public void Setup(int id, AudioSource _audioSource, UISystemTextData _textData) { }

	// RVA: 0x1FF7330 Offset: 0x1FF7431 VA: 0x1FF7330
	private int GetPlayNo(int time, int nowNo = -1) { }

	// RVA: 0x1FF7400 Offset: 0x1FF7501 VA: 0x1FF7400
	private void UpdateText(int time, int nextText) { }

	// RVA: 0x1FF7600 Offset: 0x1FF7701 VA: 0x1FF7600
	private void Update() { }

	// RVA: 0x1FF77F0 Offset: 0x1FF78F1 VA: 0x1FF77F0
	public void .ctor() { }
}

