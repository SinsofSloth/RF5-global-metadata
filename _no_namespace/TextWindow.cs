public class TextWindow : MonoBehaviour // TypeDefIndex: 7288
{
	// Fields
	[SerializeField] // RVA: 0x165580 Offset: 0x165681 VA: 0x165580
	private float textPerSec; // 0x18
	[SerializeField] // RVA: 0x165590 Offset: 0x165691 VA: 0x165590
	private float MouthTimeDelayMax; // 0x1C
	private float MouthTimeDelayNow; // 0x20
	[SerializeField] // RVA: 0x1655A0 Offset: 0x1656A1 VA: 0x1655A0
	private Text messageText; // 0x28
	private string message; // 0x30
	private int dispLength; // 0x38
	private int textLength; // 0x3C
	private float timeCount; // 0x40
	private TextOverwriteList TextOverwriteList; // 0x48
	private int addedText; // 0x50
	private string nowText; // 0x58
	[SerializeField] // RVA: 0x1655B0 Offset: 0x1656B1 VA: 0x1655B0
	private int BigSize; // 0x60
	private const int OnPlus = 1;
	private const int OnSlash = 2;
	private const int OnBig = 3;
	private const int OnColor = 4;
	private bool[] useBigOnLine; // 0x68
	private int onLine; // 0x70
	private List<int> OnUsingExcptList; // 0x78
	[SerializeField] // RVA: 0x1655C0 Offset: 0x1656C1 VA: 0x1655C0
	private Image NextIcon; // 0x80
	private bool nextFlag; // 0x88
	private bool dispNextIcon; // 0x89
	private Dictionary<int, SoundID> TextSoundDic; // 0x90
	private Dictionary<string, SoundID> TextSoundDicStr; // 0x98
	private SoundID playingId; // 0xA0

	// Methods

	// RVA: 0x20B9F70 Offset: 0x20BA071 VA: 0x20B9F70
	public void SetDispNextIcon(bool _dispNextIcon) { }

	// RVA: 0x20B9FB0 Offset: 0x20BA0B1 VA: 0x20B9FB0
	public void SetText(string text, int speakerNpcId = -1, string nameTextId = "") { }

	// RVA: 0x20BA340 Offset: 0x20BA441 VA: 0x20BA340
	public void Enable(bool flag) { }

	// RVA: 0x20BA380 Offset: 0x20BA481 VA: 0x20BA380
	private void AddStr(string t) { }

	// RVA: 0x20BA7A0 Offset: 0x20BA8A1 VA: 0x20BA7A0
	private void AddTextToDispLength() { }

	// RVA: 0x20BAAF0 Offset: 0x20BABF1 VA: 0x20BAAF0
	public void TextUpdate() { }

	// RVA: 0x20BACA0 Offset: 0x20BADA1 VA: 0x20BACA0
	public void forceDisp() { }

	// RVA: 0x20BAC80 Offset: 0x20BAD81 VA: 0x20BAC80
	public bool isUpdate() { }

	// RVA: 0x20BAD20 Offset: 0x20BAE21 VA: 0x20BAD20
	public bool isMouthEnded() { }

	// RVA: 0x20BAD30 Offset: 0x20BAE31 VA: 0x20BAD30
	private void Update() { }

	// RVA: 0x20BADF0 Offset: 0x20BAEF1 VA: 0x20BADF0
	public void .ctor() { }
}

