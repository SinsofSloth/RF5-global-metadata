public class LifeCycleAdvMain : MonoBehaviour // TypeDefIndex: 8102
{
	// Fields
	private List<LifeCycleAdvData> EventStartDataQueue; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16A5A0 Offset: 0x16A6A1 VA: 0x16A5A0
	private AdvDialogControl <advDialogControl>k__BackingField; // 0x20
	private ScriptWork scriptwork; // 0x28
	private ItemData BeforeEquipedTool; // 0x30
	private const int ScriptParamMax = 9;
	private bool IsForceText; // 0x38
	private LifeCycleAdvMain.WorkList work; // 0x3C
	private stCommand_t cmd; // 0x40
	private stCommand_t rndcmd; // 0x58
	private List<stCommand_t> cmdList; // 0x70
	private bool isWait; // 0x78
	private float waitSec; // 0x7C
	private float waitStartTime; // 0x80
	private int isSkip; // 0x84
	private bool IsCmdWait; // 0x88
	private string seName; // 0x90
	private string voiceName; // 0x98
	private NpcData npcData; // 0xA0
	private int loaderId; // 0xA8
	public bool IsAdvStarted; // 0xAC

	// Properties
	public AdvDialogControl advDialogControl { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A5C60 Offset: 0x1A5D61 VA: 0x1A5C60
	// RVA: 0x218B1F0 Offset: 0x218B2F1 VA: 0x218B1F0
	public AdvDialogControl get_advDialogControl() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5C70 Offset: 0x1A5D71 VA: 0x1A5C70
	// RVA: 0x218B200 Offset: 0x218B301 VA: 0x218B200
	private void set_advDialogControl(AdvDialogControl value) { }

	// RVA: 0x218B210 Offset: 0x218B311 VA: 0x218B210
	private void Awake() { }

	// RVA: 0x218B2C0 Offset: 0x218B3C1 VA: 0x218B2C0
	public void ForceEnd() { }

	// RVA: 0x218B2E0 Offset: 0x218B3E1 VA: 0x218B2E0
	public void AdvStart(string filePath, NpcController npc) { }

	// RVA: 0x218B640 Offset: 0x218B741 VA: 0x218B640
	private void InitAdvStart(int npcId) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5C80 Offset: 0x1A5D81 VA: 0x1A5C80
	// RVA: 0x218B8E0 Offset: 0x218B9E1 VA: 0x218B8E0
	private IEnumerator AdvStartWaitResult(string filePath, NpcController npc) { }

	// RVA: 0x218B9B0 Offset: 0x218BAB1 VA: 0x218B9B0
	public void AdvStart2(TextAsset textobj, string filePath) { }

	// RVA: 0x218BB10 Offset: 0x218BC11 VA: 0x218BB10
	public void AdvEnd(NpcController npc) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5CF0 Offset: 0x1A5DF1 VA: 0x1A5CF0
	// RVA: 0x218BC20 Offset: 0x218BD21 VA: 0x218BC20
	public IEnumerator NpcMotion(NpcController npc, int motionId, float wait) { }

	// RVA: 0x218BCF0 Offset: 0x218BDF1 VA: 0x218BCF0
	public void AdvUpdate(NpcController npc) { }

	// RVA: 0x218BE90 Offset: 0x218BF91 VA: 0x218BE90
	private LifeCycleAdvMain.WorkList ReadCommand(NpcController npc) { }

	// RVA: 0x218BEA0 Offset: 0x218BFA1 VA: 0x218BEA0
	private LifeCycleAdvMain.WorkList ReadCommandCore(NpcController npc) { }

	// RVA: 0x218E510 Offset: 0x218E611 VA: 0x218E510
	public void onPauseEnd() { }

	// RVA: 0x218E520 Offset: 0x218E621 VA: 0x218E520
	public void onTextWindowClick(int n) { }

	// RVA: 0x218E540 Offset: 0x218E641 VA: 0x218E540
	public int OnSkip(Nullable<bool> flag) { }

	// RVA: 0x218E610 Offset: 0x218E711 VA: 0x218E610
	public int GetSkipState() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5D60 Offset: 0x1A5E61 VA: 0x1A5D60
	// RVA: 0x218E430 Offset: 0x218E531 VA: 0x218E430
	public IEnumerator SetNpcPositionIdCoroutine(int npcId, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, bool relative = False) { }

	// RVA: 0x218E650 Offset: 0x218E751 VA: 0x218E650
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5DD0 Offset: 0x1A5ED1 VA: 0x1A5DD0
	// RVA: 0x218E6D0 Offset: 0x218E7D1 VA: 0x218E6D0
	private void <ReadCommandCore>b__34_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5DE0 Offset: 0x1A5EE1 VA: 0x1A5DE0
	// RVA: 0x218E6E0 Offset: 0x218E7E1 VA: 0x218E6E0
	private void <ReadCommandCore>b__34_1() { }
}

