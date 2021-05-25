public class UISubtitleMovie : MonoBehaviour // TypeDefIndex: 8862
{
	// Fields
	[SerializeField] // RVA: 0x174520 Offset: 0x174621 VA: 0x174520
	private Image BorderImage; // 0x18
	[SerializeField] // RVA: 0x174530 Offset: 0x174631 VA: 0x174530
	private Text TextObject; // 0x20
	private SubtitleDataTable.DataList playList; // 0x28
	private UISystemTextData textData; // 0x30
	private AudioSource audioSource; // 0x38
	private MoviePlayer moviePlayer; // 0x40
	private float nTime; // 0x48
	private int nowPlayNo; // 0x4C

	// Methods

	// RVA: 0x1FF66F0 Offset: 0x1FF67F1 VA: 0x1FF66F0
	public void Setup(int id, AudioSource _audioSource) { }

	// RVA: 0x1FF6890 Offset: 0x1FF6991 VA: 0x1FF6890
	public void Setup(int id, MoviePlayer _moviePlayer) { }

	// RVA: 0x1FF6A30 Offset: 0x1FF6B31 VA: 0x1FF6A30
	private int GetPlayNo(int time, int nowNo = -1) { }

	// RVA: 0x1FF6B00 Offset: 0x1FF6C01 VA: 0x1FF6B00
	private void UpdateText(int time, int nextText) { }

	// RVA: 0x1FF6DA0 Offset: 0x1FF6EA1 VA: 0x1FF6DA0
	private void Update() { }

	// RVA: 0x1FF6FE0 Offset: 0x1FF70E1 VA: 0x1FF6FE0
	public void .ctor() { }
}

