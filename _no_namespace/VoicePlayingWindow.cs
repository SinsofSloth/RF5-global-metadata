public class VoicePlayingWindow : MonoBehaviour // TypeDefIndex: 8905
{
	// Fields
	private AudioSource audioSource; // 0x18
	[SerializeField] // RVA: 0x1749C0 Offset: 0x174AC1 VA: 0x1749C0
	private CanvasGroup semiTransparent; // 0x20
	[SerializeField] // RVA: 0x1749D0 Offset: 0x174AD1 VA: 0x1749D0
	private CanvasGroup charaIconGroup; // 0x28
	[SerializeField] // RVA: 0x1749E0 Offset: 0x174AE1 VA: 0x1749E0
	private CanvasGroup speakerAndText; // 0x30
	[SerializeField] // RVA: 0x1749F0 Offset: 0x174AF1 VA: 0x1749F0
	private Image charaIcon; // 0x38
	[SerializeField] // RVA: 0x174A00 Offset: 0x174B01 VA: 0x174A00
	private Text charaText; // 0x40
	[SerializeField] // RVA: 0x174A10 Offset: 0x174B11 VA: 0x174A10
	private Text cvText; // 0x48
	[SerializeField] // RVA: 0x174A20 Offset: 0x174B21 VA: 0x174A20
	private Image speakerBorder; // 0x50
	[SerializeField] // RVA: 0x174A30 Offset: 0x174B31 VA: 0x174A30
	private Image speaker; // 0x58
	[SerializeField] // RVA: 0x174A40 Offset: 0x174B41 VA: 0x174A40
	private List<Sprite> speakerSprite; // 0x60
	private UnityAction action; // 0x68
	private RectTransform rectTransform; // 0x70
	private bool isPlaying; // 0x78
	private bool isAnimation; // 0x79
	private const float ROTATE_SPEED = -7;
	private const float SPEAKER_ANIM_SPEED = 0.8;
	private int animDir; // 0x7C
	private int spriteNo; // 0x80
	private float timeCount; // 0x84

	// Methods

	// RVA: 0x1D006B0 Offset: 0x1D007B1 VA: 0x1D006B0
	public void OpenWindow(int _index, Sprite _sprite, UnityAction _call_back, AudioClip _clip) { }

	// RVA: 0x1D01480 Offset: 0x1D01581 VA: 0x1D01480
	private void Update() { }

	// RVA: 0x1D017B0 Offset: 0x1D018B1 VA: 0x1D017B0
	private void OnSpeakerAnim() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8FB0 Offset: 0x1A90B1 VA: 0x1A8FB0
	// RVA: 0x1D01400 Offset: 0x1D01501 VA: 0x1D01400
	private IEnumerator OnStartAnim() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9020 Offset: 0x1A9121 VA: 0x1A9020
	// RVA: 0x1D01730 Offset: 0x1D01831 VA: 0x1D01730
	private IEnumerator OnEndAnim() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9090 Offset: 0x1A9191 VA: 0x1A9090
	// RVA: 0x1D01970 Offset: 0x1D01A71 VA: 0x1D01970
	private IEnumerator PlayFadeAnim(bool _flag, CanvasGroup _target) { }

	// RVA: 0x1D01A30 Offset: 0x1D01B31 VA: 0x1D01A30
	private void InvokeCallBack() { }

	// RVA: 0x1D01A80 Offset: 0x1D01B81 VA: 0x1D01A80
	public void .ctor() { }
}

