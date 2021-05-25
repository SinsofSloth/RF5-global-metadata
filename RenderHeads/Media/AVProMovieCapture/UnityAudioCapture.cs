[AddComponentMenu] // RVA: 0x149070 Offset: 0x149171 VA: 0x149070
public class UnityAudioCapture : MonoBehaviour // TypeDefIndex: 9602
{
	// Fields
	[SerializeField] // RVA: 0x17D390 Offset: 0x17D491 VA: 0x17D390
	private bool _debugLogging; // 0x18
	[SerializeField] // RVA: 0x17D3A0 Offset: 0x17D4A1 VA: 0x17D3A0
	private bool _muteAudio; // 0x19
	private const int BufferSize = 16;
	private float[] _buffer; // 0x20
	private float[] _readBuffer; // 0x28
	private int _bufferIndex; // 0x30
	private GCHandle _bufferHandle; // 0x34
	private int _numChannels; // 0x38
	private int _overflowCount; // 0x3C
	private object _lockObject; // 0x40

	// Properties
	public float[] Buffer { get; }
	public int BufferLength { get; }
	public int NumChannels { get; }
	public IntPtr BufferPtr { get; }
	public int OverflowCount { get; }

	// Methods

	// RVA: 0x23286D0 Offset: 0x23287D1 VA: 0x23286D0
	public float[] get_Buffer() { }

	// RVA: 0x23286E0 Offset: 0x23287E1 VA: 0x23286E0
	public int get_BufferLength() { }

	// RVA: 0x23286F0 Offset: 0x23287F1 VA: 0x23286F0
	public int get_NumChannels() { }

	// RVA: 0x2328700 Offset: 0x2328801 VA: 0x2328700
	public IntPtr get_BufferPtr() { }

	// RVA: 0x2328710 Offset: 0x2328811 VA: 0x2328710
	public int get_OverflowCount() { }

	// RVA: 0x2328720 Offset: 0x2328821 VA: 0x2328720
	private void OnEnable() { }

	// RVA: 0x2328B60 Offset: 0x2328C61 VA: 0x2328B60
	private void OnDisable() { }

	// RVA: 0x23180D0 Offset: 0x23181D1 VA: 0x23180D0
	public IntPtr ReadData(out int length) { }

	// RVA: 0x2328C60 Offset: 0x2328D61 VA: 0x2328C60
	public void FlushBuffer() { }

	// RVA: 0x2328CF0 Offset: 0x2328DF1 VA: 0x2328CF0
	private void OnAudioFilterRead(float[] data, int channels) { }

	// RVA: 0x2328B30 Offset: 0x2328C31 VA: 0x2328B30
	public static int GetNumChannels(AudioSpeakerMode mode) { }

	// RVA: 0x2328FD0 Offset: 0x23290D1 VA: 0x2328FD0
	public void .ctor() { }
}

