public class AdvMain : MonoBehaviour // TypeDefIndex: 7119
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x163000 Offset: 0x163101 VA: 0x163000
	private static AdvMain <Instance>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x163010 Offset: 0x163111 VA: 0x163010
	private AdvDialogControl <advDialogControl>k__BackingField; // 0x18
	private ScriptWork scriptwork; // 0x20
	public Action completeFunc; // 0x28
	public UnityAction _endAction; // 0x30
	private ItemData BeforeEquipedTool; // 0x38
	public bool IsPCBattleModeRelease; // 0x40
	private GameObject EventTimelineObj; // 0x48
	private GameObject TimeLineObject; // 0x50
	private bool IsTimelineStartCalled; // 0x58
	public int IsTimelineEndWait; // 0x5C
	private const int ScriptParamMax = 9;
	private bool IsForceText; // 0x60
	private bool IsAdvCreatedByCmd; // 0x61
	private int advCmdCnt; // 0x64
	private AdvMain.WorkList nextWork; // 0x68
	private int ChangeSceneCount; // 0x6C
	private VariationNo playerVariation; // 0x70
	private AdvMain.WorkList work; // 0x74
	private stCommand_t Cmd; // 0x78
	private stCommand_t rndCmd; // 0x90
	private List<stCommand_t> cmdList; // 0xA8
	private bool isWait; // 0xB0
	private float waitSec; // 0xB4
	private float waitStartTime; // 0xB8
	private TextWindow textWindow; // 0xC0
	private NameWindow nameWindow; // 0xC8
	private int isSkip; // 0xD0
	private bool IsCmdWait; // 0xD4
	private int SelectMenuCount; // 0xD8
	private int SelectMenuTotalCount; // 0xDC
	private string seName; // 0xE0
	private string voiceName; // 0xE8
	private string[] JumpReserveScript; // 0xF0
	private int autoModeWaitCountMax; // 0xF8
	private int autoModeWaitCount; // 0xFC
	private Shake shake; // 0x100
	public bool skipable; // 0x108
	public bool advskip; // 0x109
	private int checkNpcId; // 0x10C
	private int ChangeNpcId; // 0x110
	private int ChangeVariationNo; // 0x114
	private bool IsChangeVariation; // 0x118
	private readonly int VARIATION_ORIGIN; // 0x11C
	private int MoveCharaCount; // 0x120
	private bool IsSystemFadeIn; // 0x124
	private List<int> listPreloadRes; // 0x128
	private List<string> hintNames; // 0x130
	private List<string> hintMsgs; // 0x138
	private List<TimelineMsg> TimelineMsgList; // 0x140
	private bool isSeriousScripts; // 0x148
	private SeriousEventScripts seriousEventScripts; // 0x150
	public int loadcount; // 0x158
	private bool IsBedSkip; // 0x15C

	// Properties
	public static AdvMain Instance { get; set; }
	public AdvDialogControl advDialogControl { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DF60 Offset: 0x19E061 VA: 0x19DF60
	// RVA: 0x1BFBEC0 Offset: 0x1BFBFC1 VA: 0x1BFBEC0
	public static AdvMain get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DF70 Offset: 0x19E071 VA: 0x19DF70
	// RVA: 0x1BFBF10 Offset: 0x1BFC011 VA: 0x1BFBF10
	private static void set_Instance(AdvMain value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19DF80 Offset: 0x19E081 VA: 0x19DF80
	// RVA: 0x1BFBF70 Offset: 0x1BFC071 VA: 0x1BFBF70
	public AdvDialogControl get_advDialogControl() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DF90 Offset: 0x19E091 VA: 0x19DF90
	// RVA: 0x1BFBF80 Offset: 0x1BFC081 VA: 0x1BFBF80
	private void set_advDialogControl(AdvDialogControl value) { }

	// RVA: 0x1BFBF90 Offset: 0x1BFC091 VA: 0x1BFBF90
	public List<int> DontDestoryNpcList() { }

	// RVA: 0x1BFBFB0 Offset: 0x1BFC0B1 VA: 0x1BFBFB0
	public void TimelineMsgListClear() { }

	// RVA: 0x1BFC010 Offset: 0x1BFC111 VA: 0x1BFC010
	public void AddTimelineMsg(TimelineMsg tmsg) { }

	// RVA: 0x1BFC080 Offset: 0x1BFC181 VA: 0x1BFC080
	public void ShowTimelineMsg(TimelineMsgID msgId) { }

	// RVA: 0x1BFC220 Offset: 0x1BFC321 VA: 0x1BFC220
	private void LoadTimeLineMSGTable(TimelineMsgID msgId, AssetHandle<TimelineMsgData> handle) { }

	// RVA: 0x1BFC490 Offset: 0x1BFC591 VA: 0x1BFC490
	private void Awake() { }

	// RVA: 0x1BFC770 Offset: 0x1BFC871 VA: 0x1BFC770
	private void Start() { }

	// RVA: 0x1BFC820 Offset: 0x1BFC921 VA: 0x1BFC820
	public string GetCurrentScriptName() { }

	// RVA: 0x1BFC840 Offset: 0x1BFC941 VA: 0x1BFC840
	private void ReSearch(bool research) { }

	// RVA: 0x1BFCA70 Offset: 0x1BFCB71 VA: 0x1BFCA70
	public bool AdvStart(string filePath, NpcController npc, bool research = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x19DFA0 Offset: 0x19E0A1 VA: 0x19DFA0
	// RVA: 0x1BFD0F0 Offset: 0x1BFD1F1 VA: 0x1BFD0F0
	private IEnumerator AdvStartWaitResult(AdvScriptId advindex, string filePath, bool research = False) { }

	// RVA: 0x1BFD1B0 Offset: 0x1BFD2B1 VA: 0x1BFD1B0
	public void AdvPreLoadStart(byte[] textobj, string filePath, bool research = False) { }

	// RVA: 0x1BFE410 Offset: 0x1BFE511 VA: 0x1BFE410
	public void AddPreLoadCount() { }

	// RVA: 0x1BFE420 Offset: 0x1BFE521 VA: 0x1BFE420
	public void PreloadWait() { }

	// RVA: 0x1BFE290 Offset: 0x1BFE391 VA: 0x1BFE290
	public void AdvPreLoadEnd() { }

	// RVA: 0x1BFCA00 Offset: 0x1BFCB01 VA: 0x1BFCA00
	public bool AdvEnd() { }

	// RVA: 0x1BFC210 Offset: 0x1BFC311 VA: 0x1BFC210
	public void SetForceText(string nametext, string chattext, bool timelineMsg) { }

	// RVA: 0x1BFE6B0 Offset: 0x1BFE7B1 VA: 0x1BFE6B0
	public void SetForceText(string nametext, string chattext, bool timelineMsg, UnityAction callBackAction) { }

	// RVA: 0x1BFE770 Offset: 0x1BFE871 VA: 0x1BFE770
	public void SetEndAction(UnityAction callBackAction) { }

	// RVA: 0x1BFC480 Offset: 0x1BFC581 VA: 0x1BFC480
	public void SetForceTextAddSpeakerNpcId(string nametext, string chattext, bool timelineMsg, int speakerNpcId) { }

	// RVA: 0x1BFE580 Offset: 0x1BFE681 VA: 0x1BFE580
	public void SetForceTextBase(string nametext, string chattext, bool timelineMsg, int speakerNpcId = -1) { }

	// RVA: 0x1BFE780 Offset: 0x1BFE881 VA: 0x1BFE780
	public void AdvUpdate(NpcController npc) { }

	// RVA: 0x1C0DEE0 Offset: 0x1C0DFE1 VA: 0x1C0DEE0
	public void EventAdvFinish() { }

	// RVA: 0x1C0E050 Offset: 0x1C0E151 VA: 0x1C0E050
	public int GetAdvCostumeId(int charaId, int variationId) { }

	// RVA: 0x1BFF2C0 Offset: 0x1BFF3C1 VA: 0x1BFF2C0
	private AdvMain.WorkList ReadCommand(NpcController npc) { }

	// RVA: 0x1C0E670 Offset: 0x1C0E771 VA: 0x1C0E670
	public void onPauseEnd() { }

	// RVA: 0x1C0E690 Offset: 0x1C0E791 VA: 0x1C0E690
	public void TimelineEnd() { }

	// RVA: 0x1C0E730 Offset: 0x1C0E831 VA: 0x1C0E730
	public void onReadText() { }

	// RVA: 0x1C0E760 Offset: 0x1C0E861 VA: 0x1C0E760
	public void disableForceText() { }

	// RVA: 0x1BFF130 Offset: 0x1BFF231 VA: 0x1BFF130
	public void onTextWindowClick() { }

	// RVA: 0x1C0E840 Offset: 0x1C0E941 VA: 0x1C0E840
	public void AdvSkip() { }

	// RVA: 0x1C0E770 Offset: 0x1C0E871 VA: 0x1C0E770
	public void DisableForceText() { }

	// RVA: 0x1C0E8E0 Offset: 0x1C0E9E1 VA: 0x1C0E8E0
	public int OnSkip(Nullable<bool> flag) { }

	// RVA: 0x1C0E9B0 Offset: 0x1C0EAB1 VA: 0x1C0E9B0
	public int GetSkipState() { }

	// RVA: 0x1C0E9C0 Offset: 0x1C0EAC1 VA: 0x1C0E9C0
	public void AdvStartByCmd(stCommand_t[] _cmdList, bool resetStep = True) { }

	// RVA: 0x1C0EC20 Offset: 0x1C0ED21 VA: 0x1C0EC20
	public void SubMoveCharaCount() { }

	// RVA: 0x1C0E330 Offset: 0x1C0E431 VA: 0x1C0E330
	public void UiHide() { }

	// RVA: 0x1C0EC40 Offset: 0x1C0ED41 VA: 0x1C0EC40
	public void SetNamePlate(string nametext, bool moreThanLover = False) { }

	// RVA: 0x1C0E110 Offset: 0x1C0E211 VA: 0x1C0E110
	private void SystemFadeIn(CommandList cmdId, int[] cmdArg) { }

	// RVA: 0x1BFDBF0 Offset: 0x1BFDCF1 VA: 0x1BFDBF0
	private void PlayerUnEquipForAdv() { }

	// RVA: 0x1C0EC60 Offset: 0x1C0ED61 VA: 0x1C0EC60
	public void ForceEndWork() { }

	// RVA: 0x1BFDDB0 Offset: 0x1BFDEB1 VA: 0x1BFDDB0
	public int GetFesNpcId(int fesNpcId) { }

	// RVA: 0x1BFE1A0 Offset: 0x1BFE2A1 VA: 0x1BFE1A0
	public bool CanBathPartnerNpcId(int charCmdId, int npcId) { }

	// RVA: 0x1C0E580 Offset: 0x1C0E681 VA: 0x1C0E580
	private void DoorClose(string door_name) { }

	// RVA: 0x1BFCC70 Offset: 0x1BFCD71 VA: 0x1BFCC70
	private void JudgeSeriousScripts(string scriptsName) { }

	// RVA: 0x1C0EC80 Offset: 0x1C0ED81 VA: 0x1C0EC80
	private void ChangeIsBedSkip(bool value) { }

	// RVA: 0x1C0E2C0 Offset: 0x1C0E3C1 VA: 0x1C0E2C0
	private bool CheckBedSkipCommandID(int cmdId) { }

	// RVA: 0x1C0EC90 Offset: 0x1C0ED91 VA: 0x1C0EC90
	public bool CanBedSkip() { }

	// RVA: 0x1C0EE50 Offset: 0x1C0EF51 VA: 0x1C0EE50
	public void DoBedSkip() { }

	// RVA: 0x1C0EFB0 Offset: 0x1C0F0B1 VA: 0x1C0EFB0
	public void BedSkipEnd(float fadeTime = 0.5) { }

	// RVA: 0x1C0F180 Offset: 0x1C0F281 VA: 0x1C0F180
	private bool CheckMessageID(int cmdId) { }

	// RVA: 0x1C0F1A0 Offset: 0x1C0F2A1 VA: 0x1C0F1A0
	private AdvMain.WorkList ReadCommand_TextChecker(NpcController npc) { }

	// RVA: 0x1C10470 Offset: 0x1C10571 VA: 0x1C10470
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E010 Offset: 0x19E111 VA: 0x19E010
	// RVA: 0x1C105A0 Offset: 0x1C106A1 VA: 0x1C105A0
	private void <ReadCommand>b__84_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E020 Offset: 0x19E121 VA: 0x19E020
	// RVA: 0x1C105B0 Offset: 0x1C106B1 VA: 0x1C105B0
	private void <ReadCommand>b__84_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E030 Offset: 0x19E131 VA: 0x19E030
	// RVA: 0x1C105C0 Offset: 0x1C106C1 VA: 0x1C105C0
	private void <ReadCommand>b__84_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E040 Offset: 0x19E141 VA: 0x19E040
	// RVA: 0x1C105D0 Offset: 0x1C106D1 VA: 0x1C105D0
	private void <ReadCommand>b__84_7() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E050 Offset: 0x19E151 VA: 0x19E050
	// RVA: 0x1C105E0 Offset: 0x1C106E1 VA: 0x1C105E0
	private void <ReadCommand>b__84_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E060 Offset: 0x19E161 VA: 0x19E060
	// RVA: 0x1C105F0 Offset: 0x1C106F1 VA: 0x1C105F0
	private void <DoBedSkip>b__109_0() { }
}

