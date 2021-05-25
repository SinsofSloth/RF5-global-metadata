public class UILoadingStreamer : MonoBehaviour // TypeDefIndex: 9092
{
	// Fields
	[TooltipAttribute] // RVA: 0x176F80 Offset: 0x177081 VA: 0x176F80
	public Streamer[] streamers; // 0x18
	public Image progressImg; // 0x20
	[TooltipAttribute] // RVA: 0x176FC0 Offset: 0x1770C1 VA: 0x176FC0
	public float waitTime; // 0x28
	public UnityEvent onDone; // 0x30
	private Coroutine TurnOffCoroutine; // 0x38

	// Methods

	// RVA: 0x1ED9A60 Offset: 0x1ED9B61 VA: 0x1ED9A60
	private void Awake() { }

	// RVA: 0x1ED9B00 Offset: 0x1ED9C01 VA: 0x1ED9B00
	private void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9730 Offset: 0x1A9831 VA: 0x1A9730
	// RVA: 0x1ED9CC0 Offset: 0x1ED9DC1 VA: 0x1ED9CC0
	public IEnumerator TurnOff() { }

	// RVA: 0x1ED9D70 Offset: 0x1ED9E71 VA: 0x1ED9D70
	public void Show() { }

	// RVA: 0x1ED9DF0 Offset: 0x1ED9EF1 VA: 0x1ED9DF0
	public void Hide() { }

	// RVA: 0x1ED9EC0 Offset: 0x1ED9FC1 VA: 0x1ED9EC0
	public void .ctor() { }
}

